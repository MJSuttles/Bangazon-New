using Bangazon.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore.Query;
using Npgsql.Internal;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<BangazonDbContext>(builder.Configuration["BangazonDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// Configure CORS policy to allow frontend requests
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        {
            policy.WithOrigins("http://localhost:3000")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Apply CORS before routing
app.UseCors();

app.UseHttpsRedirection();

// API Calls

// CART Calls

// GET Customer Cart

app.MapGet("/api/cart/{userId}", (BangazonDbContext db, string userId) =>
{
    Cart cart = db.Carts
        .Include(c => c.CartItems)
        .ThenInclude(ci => ci.Product)
        .FirstOrDefault(c => c.UserId == userId);

    if (cart == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(cart);
});

// Add to Cart

app.MapPost("/api/cart/add", (BangazonDbContext db, AddToCartRequest request) =>
{
    if (request == null || string.IsNullOrEmpty(request.UserId) || request.ProductId <= 0 || request.Quantity <= 0)
    {
        return Results.BadRequest("Invalid request data.");
    }

    var cart = db.Carts.FirstOrDefault(c => c.UserId == request.UserId);

    if (cart == null)
    {
        cart = new Cart { UserId = request.UserId };
        db.Carts.Add(cart);
        db.SaveChanges();
    }

    var cartItem = db.CartItems.FirstOrDefault(ci => ci.CartId == cart.Id && ci.ProductId == request.ProductId);

    if (cartItem == null)
    {
        cartItem = new CartItem { CartId = cart.Id, ProductId = request.ProductId, Quantity = request.Quantity };
        db.CartItems.Add(cartItem);
    }
    else
    {
        cartItem.Quantity += request.Quantity;
    }

    db.SaveChanges();
    return Results.Ok(cart);
});


// Add Payment Method to Cart

app.MapPost("/api/cart/add-payment", async (HttpContext context, BangazonDbContext db) =>
{
    try
    {
        var requestBody = await context.Request.ReadFromJsonAsync<PaymentMethodRequest>();

        Console.WriteLine($"📥 Received Payment Request: UserId={requestBody?.UserId}, PaymentMethodId={requestBody?.PaymentMethodId}");

        if (requestBody == null || string.IsNullOrEmpty(requestBody.UserId) || requestBody.PaymentMethodId <= 0)
        {
            Console.WriteLine("❌ Invalid request data");
            return Results.BadRequest("Invalid request data.");
        }

        var cart = db.Carts.FirstOrDefault(c => c.UserId == requestBody.UserId);

        if (cart == null)
        {
            Console.WriteLine("❌ Cart not found.");
            return Results.NotFound("Cart not found.");
        }

        cart.UserPaymentMethodId = requestBody.PaymentMethodId;
        db.SaveChanges();

        Console.WriteLine("✅ Payment method successfully added.");
        return Results.Ok(cart);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Exception: {ex.Message}");
        return Results.Problem("Internal server error.");
    }
});

// DELETE Item from Cart
app.MapDelete("/api/cart/delete-item", (BangazonDbContext db, int cartId, int cartItemId, int productId) =>
{
    // Fetch the cart along with its items
    Cart? cart = db.Carts
       .Include(c => c.CartItems)
       .ThenInclude(ci => ci.Product) // Assuming a navigation property exists
       .SingleOrDefault(c => c.Id == cartId);

    if (cart == null)
    {
        return Results.NotFound("Cart not found.");
    }

    // Find the specific cart item to delete
    CartItem? cartItemToDelete = cart.CartItems.SingleOrDefault(ci => ci.Id == cartItemId && ci.ProductId == productId);

    if (cartItemToDelete == null)
    {
        return Results.NotFound("Cart item not found.");
    }

    db.CartItems.Remove(cartItemToDelete);
    db.SaveChanges();

    return Results.NoContent(); // ✅ HTTP 204 - Successfully deleted
});

// CARTITEMS Calls



// CATEGORY Calls


// ORDER Calls

// GET Orders by Seller

app.MapGet("/api/orders/sellers/{sellerId}", (BangazonDbContext db, string sellerId) =>
{
    List<Order> orders = db.Orders
        .Where(o => o.IsComplete == true && o.OrderItems.Any(oi => oi.SellerId == sellerId))
        .Include(o => o.OrderItems)
        .ThenInclude(oi => oi.Product)
        .ToList();

    if (!orders.Any())
    {
        return Results.NotFound();
    }

    return Results.Ok(orders);
});

// POST then Complete Order (Moves Items to Order and Clears the Cart)

app.MapPost("/api/orders/complete", (BangazonDbContext db, string userId) =>
{
    Cart cart = db.Carts.Include(c => c.CartItems).FirstOrDefault(c => c.UserId == userId);

    if (cart == null || !cart.CartItems.Any())
    {
        return Results.BadRequest("Cart is empty");
    }

    // ✅ Order starts with isComplete = false and sets OrderDate
    Order order = new Order
    {
        CustomerId = userId,
        UserPaymentMethodId = cart.UserPaymentMethodId,
        IsComplete = false, // ✅ Order is not complete until payment is confirmed
        OrderDate = DateTime.UtcNow // ✅ Add OrderDate when order is created
    };

    db.Orders.Add(order);
    db.SaveChanges();

    List<OrderItem> orderItems = cart.CartItems.Select(ci => new OrderItem
    {
        OrderId = order.Id,
        ProductId = ci.ProductId,
        Quantity = ci.Quantity,
        SellerId = db.Products.FirstOrDefault(p => p.Id == ci.ProductId)?.SellerId ?? ""
    }).ToList();

    db.OrderItems.AddRange(orderItems);
    db.CartItems.RemoveRange(cart.CartItems); // Clears cart items
    db.Carts.Remove(cart); // Removes cart after checkout
    db.SaveChanges();

    return Results.Ok(order);
});

// ✅ Separate API call to mark order as complete when payment is provided
app.MapPost("/api/orders/confirm-payment/{orderId}", (BangazonDbContext db, int orderId) =>
{
    Order order = db.Orders.FirstOrDefault(o => o.Id == orderId);

    if (order == null)
    {
        return Results.NotFound("Order not found.");
    }

    // ✅ Change isComplete to true once payment is confirmed
    order.IsComplete = true;
    db.SaveChanges();

    return Results.Ok(order);
});



// app.MapPost("/api/orders/{uid}", (BangazonDbContext db, string uid) =>
// {
//     Cart cart = db.Carts.Include(c => c.CartItems).FirstOrDefault(c => c.UserId == uid);

//     Console.WriteLine($"My cart {cart}");
// });

// GET Orders by Customer

// app.MapGet("/api/orders/{id}", (BangazonDbContext db, int id) =>
// {
//     Order? order = db.Orders
//         .Where(o => o.Id == id)
//         .Include(o => o.OrderItems)
//         .ThenInclude(oi => oi.Product) // ✅ Include Product for SellerId reference
//         .FirstOrDefault();

//     if (order == null)
//     {
//         return Results.NotFound();
//     }

//     // ✅ Fetch Seller details using the SellerId from the Product table
//     var orderDetails = new
//     {
//         order.Id,
//         order.CustomerId,
//         order.UserPaymentMethodId,
//         order.IsComplete,
//         order.OrderDate, // ✅ Include OrderDate in response
//         OrderItems = order.OrderItems.Select(oi => new
//         {
//             oi.ProductId,
//             oi.Quantity,
//             ProductName = oi.Product.Name,
//             Category = oi.Product.Category.Title,
//             Price = oi.Product.Price,
//             Image = oi.Product.Image,
//             Seller = db.Users
//                 .Where(u => u.Uid == oi.Product.SellerId)
//                 .Select(s => new
//                 {
//                     s.Uid,
//                     s.FirstName,
//                     s.LastName,
//                     s.Email,
//                     s.Address,
//                     s.City,
//                     s.State,
//                     s.Zip
//                 })
//                 .FirstOrDefault() // ✅ Get seller details for each product
//         }).ToList() // ✅ Convert to list
//     };

//     return Results.Ok(orderDetails);
// });

app.MapGet("/api/orders/user/{customerId}", (BangazonDbContext db, string customerId) =>
{
    var orders = db.Orders
        .Where(o => o.CustomerId == customerId) // ✅ Fetch orders by CustomerId (User ID)
        .Include(o => o.OrderItems)
        .ThenInclude(oi => oi.Product)
        .ToList();

    if (!orders.Any())
    {
        return Results.NotFound("No orders found for this user.");
    }

    var orderDetails = orders.Select(order => new
    {
        order.Id,
        order.CustomerId,
        order.UserPaymentMethodId,
        order.IsComplete,
        order.OrderDate,
        OrderItems = order.OrderItems.Select(oi => new
        {
            oi.ProductId,
            oi.Quantity,
            ProductName = oi.Product.Name,
            Category = oi.Product.Category.Title,
            Price = oi.Product.Price,
            Image = oi.Product.Image,
            Seller = db.Users
                .Where(u => u.Uid == oi.Product.SellerId)
                .Select(s => new
                {
                    s.Uid,
                    s.FirstName,
                    s.LastName,
                    s.Email,
                    s.Address,
                    s.City,
                    s.State,
                    s.Zip
                })
                .FirstOrDefault()
        }).ToList()
    }).ToList();

    return Results.Ok(orderDetails);
});


// ORDERITEM Calls



// PAYMENTOPTION Calls

app.MapGet("/api/payment-options", (BangazonDbContext db) =>
{
    var paymentOptions = db.PaymentOptions.ToList();
    return Results.Ok(paymentOptions);
});


// PRODUCT Calls

// GET Products by Id

app.MapGet("/api/products/{id}", (BangazonDbContext db, int id) =>
{
    var product = db.Products
        .Include(p => p.Category)
        .FirstOrDefault(p => p.Id == id);

    if (product == null)
    {
        return Results.NotFound();
    }

    // ✅ Fetch seller details from Users table
    var seller = db.Users.FirstOrDefault(u => u.Uid == product.SellerId);

    return Results.Ok(new
    {
        product.Id,
        product.Name,
        product.IsAvailable,
        product.Price,
        product.Image,
        product.Description,
        product.Quantity,
        Category = product.Category.Title,
        Seller = seller != null ? $"{seller.FirstName} {seller.LastName}" : "Unknown" // ✅ Fix seller name issue
    });
});

// GET All Products

app.MapGet("/api/products", (BangazonDbContext db) =>
{
    return db.Products.ToList();
});

// GET Products by Category

app.MapGet("/api/products/category/{categoryId}", (BangazonDbContext db, int categoryId) =>
{
    List<Product> products = db.Products
        .Where(p => p.CategoryId == categoryId) // filters products by CategoryId
        .Include(p => p.Category) // includes category details
        .ToList();

    if (!products.Any())
    {
        return Results.NotFound($"No products found in the {categoryId} category.");
    }

    return Results.Ok(products);
});

// GET Products by Seller

app.MapGet("/api/products/seller/{sellerId}", (BangazonDbContext db, string sellerId) =>
{
    List<Product> products = db.Products
        .Where(p => p.SellerId == sellerId)
        .Include(p => p.Category)
        .ToList();

    if (!products.Any())
    {
        return Results.NotFound("You have no products available to sell.");
    }

    return Results.Ok(products);
});

// GET 20 Latest Products

app.MapGet("/api/products/latest", (BangazonDbContext db) =>
{
    List<Product> latestProducts = db.Products
        .OrderByDescending(p => p.Id)
        .Take(20)
        .Include(p => p.Category)
        .ToList();

    return Results.Ok(latestProducts);
});


// USER Calls

// GET User
app.MapGet("/api/users/{uid}", (BangazonDbContext db, string uid) =>
{
    User user = db.Users
        .FirstOrDefault(u => u.Uid == uid);

    if (user == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(user);
});

// Add User

app.MapGet("/api/checkuser/{userId}", (BangazonDbContext db, string userId) =>
{
    var user = db.Users.FirstOrDefault(u => u.Uid == userId);

    if (user == null)
    {
        return Results.Json(new
        {
            status = "not_found",
            message = "User not found. Redirecting to registration.",
            redirect = "/register"
        }, statusCode: 404);
    }

    return Results.Ok(user);
});

app.MapPost("/api/register", (BangazonDbContext db, User user) =>
{
    db.Users.Add(user);
    db.SaveChanges();
    return Results.Created($"/users/{user.Uid}", user);
});

// GET User Details

app.MapGet("/api/users/userdetails/{uid}", (BangazonDbContext db, string uid) =>
{
    User user = db.Users
        .FirstOrDefault(u => u.Uid == uid);

    if (user == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(user);
});

// GET Seller Dashboard

app.MapGet("/api/seller/dashboard/{sellerId}", (BangazonDbContext db, string sellerId) =>
{
    // ✅ Total Sales
    decimal totalSales = db.OrderItems
        .Where(oi => oi.SellerId == sellerId && oi.Order.IsComplete)
        .Sum(oi => oi.Quantity * oi.Product.Price);

    // ✅ Total Sales This Month (Replace `CreatedAt` with `OrderDate`)
    decimal totalSalesThisMonth = db.OrderItems
        .Where(oi => oi.SellerId == sellerId && oi.Order.IsComplete && oi.Order.OrderDate.Month == DateTime.UtcNow.Month)
        .Sum(oi => oi.Quantity * oi.Product.Price);

    // ✅ Average Sales per Item
    decimal averageSalesPerItem = db.OrderItems
        .Where(oi => oi.SellerId == sellerId && oi.Order.IsComplete)
        .GroupBy(oi => oi.ProductId)
        .Select(g => g.Sum(oi => oi.Quantity * oi.Product.Price))
        .DefaultIfEmpty(0)
        .Average();

    // ✅ Total Inventory by Category
    var inventoryByCategory = db.Products
        .Where(p => p.SellerId == sellerId)
        .GroupBy(p => p.Category.Title)
        .Select(g => new
        {
            Category = g.Key,
            TotalStock = g.Sum(p => p.Quantity)
        })
        .ToList();

    // ✅ Build and return the dashboard data
    var dashboardData = new
    {
        TotalSales = totalSales,
        TotalSalesThisMonth = totalSalesThisMonth,
        AverageSalesPerItem = averageSalesPerItem,
        InventoryByCategory = inventoryByCategory
    };

    return Results.Ok(dashboardData);
});




// USERPAYMENTMETHOD Calls



// SEARCH Calls

// GET Search by Product Name

app.MapGet("/api/products/search", (BangazonDbContext db, string searchTerm) =>
{
    var products = db.Products
        .Where(p => p.Name.ToLower().Contains(searchTerm.ToLower())) // ✅ Case-insensitive search
        .Include(p => p.Category) // ✅ Include Category data
        .ToList();

    if (!products.Any())
    {
        return Results.NotFound("No products found.");
    }

    return Results.Ok(products);
});

// GET Search by Seller Name

app.MapGet("/api/sellers/search", (BangazonDbContext db, string searchTerm) =>
{
    var sellerUids = db.Users
        .Where(u => u.FirstName.ToLower().Contains(searchTerm.ToLower())
                 || u.LastName.ToLower().Contains(searchTerm.ToLower()))
        .Select(u => u.Uid)
        .ToList();

    if (!sellerUids.Any())
    {
        return Results.NotFound("No sellers found.");
    }

    var sellersWithProducts = db.Products
        .Where(p => sellerUids.Contains(p.SellerId)) // ✅ Ensure seller has products
        .Select(p => p.SellerId)
        .Distinct()
        .ToList();

    var sellers = db.Users
        .Where(u => sellersWithProducts.Contains(u.Uid)) // ✅ Filter only sellers with products
        .Select(u => new
        {
            u.Uid,
            u.FirstName,
            u.LastName,
            u.Email
        })
        .ToList();

    if (!sellers.Any())
    {
        return Results.NotFound("No matching sellers with products found.");
    }

    return Results.Ok(sellers);
});


app.Run();
