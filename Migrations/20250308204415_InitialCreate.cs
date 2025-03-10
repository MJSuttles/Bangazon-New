using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bangazon_New.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Uid = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Zip = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    SellerId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    UserPaymentMethodId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    PaymentOptionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPaymentMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPaymentMethods_PaymentOptions_PaymentOptionId",
                        column: x => x.PaymentOptionId,
                        principalTable: "PaymentOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPaymentMethods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CartId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<string>(type: "text", nullable: false),
                    IsComplete = table.Column<bool>(type: "boolean", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserPaymentMethodId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_UserPaymentMethods_UserPaymentMethodId",
                        column: x => x.UserPaymentMethodId,
                        principalTable: "UserPaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    SellerId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Vinyl" },
                    { 2, "Cassette" },
                    { 3, "Compact Disc" }
                });

            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Credit Card" },
                    { 2, "Apple Pay" },
                    { 3, "Google Pay" },
                    { 4, "PayPal" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Uid", "Address", "City", "Email", "FirstName", "LastName", "State", "Zip" },
                values: new object[,]
                {
                    { "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a", "654 Cedar Road", "Louisville", "charliem@example.com", "Charlie", "Miller", "KY", "40202" },
                    { "6Na5niFGCaUfZz7y9cjbFEq8twj1", "123 Elm Street", "Nashville", "rolltiderolldad@gmail.com", "Brian", "Suttles", "TN", "37201" },
                    { "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75", "789 Pine Street", "Atlanta", "alicej@example.com", "Alice", "Johnson", "GA", "30301" },
                    { "fa80e4a1-53b7-4784-ab59-6574dea65bb0", "321 Maple Avenue", "Charlotte", "bobb@example.com", "Bob", "Brown", "NC", "28202" },
                    { "l4XlJweAr3USaFL4DW3h2PfIqAC3", "123 Elm Street", "Nashville", "suttles95@gmail.com", "Dayna", "Suttles", "TN", "37201" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "IsAvailable", "Name", "Price", "Quantity", "SellerId" },
                values: new object[,]
                {
                    { 1, 1, "Fleetwood Mac's best-selling album.", "https://m.media-amazon.com/images/I/71WxpWovLTL._SL1500_.jpg", true, "Rumours", 47.36m, 5, "6Na5niFGCaUfZz7y9cjbFEq8twj1" },
                    { 2, 1, "Classic Pink Floyd album.", "https://m.media-amazon.com/images/I/81j3Su+bWjL._SL1500_.jpg", true, "Dark Side of the Moon", 51.99m, 3, "BCyBV6WJpTZcPG0b0WMfr8vJM1B3" },
                    { 3, 1, "The Beatles' famous album.", "https://m.media-amazon.com/images/I/81Sl5vNuxBL._SL1500_.jpg", true, "Abbey Road", 38.50m, 7, "BCyBV6WJpTZcPG0b0WMfr8vJM1B3" },
                    { 4, 2, "Alanis Morissette's breakthrough album.", "https://m.media-amazon.com/images/I/71+WumJptUL._SL1400_.jpg", true, "Jagged Little Pill", 15.99m, 4, "BCyBV6WJpTZcPG0b0WMfr8vJM1B3" },
                    { 5, 2, "Nirvana's best-known record.", "https://m.media-amazon.com/images/I/71NRSUUMZXL._SL1400_.jpg", true, "Nevermind", 29.99m, 6, "BCyBV6WJpTZcPG0b0WMfr8vJM1B3" },
                    { 6, 3, "Adele's Grammy-winning album.", "https://m.media-amazon.com/images/I/71d3FbEovhL._SL1400_.jpg", true, "21", 19.99m, 3, "BCyBV6WJpTZcPG0b0WMfr8vJM1B3" },
                    { 7, 3, "Lady Gaga's iconic album.", "https://m.media-amazon.com/images/I/91m3bJ6geTL._SL1500_.jpg", true, "Born This Way", 22.99m, 2, "BCyBV6WJpTZcPG0b0WMfr8vJM1B3" },
                    { 8, 1, "Michael Jackson's best-selling album.", "https://m.media-amazon.com/images/I/81WcnNQ-TBL._SL1500_.jpg", true, "Thriller", 45.00m, 9, "BCyBV6WJpTZcPG0b0WMfr8vJM1B3" },
                    { 9, 1, "Pink Floyd's rock opera.", "https://m.media-amazon.com/images/I/71OQVoZt3ML._SL1500_.jpg", true, "The Wall", 50.00m, 4, "BCyBV6WJpTZcPG0b0WMfr8vJM1B3" },
                    { 10, 2, "AC/DC's legendary album.", "https://m.media-amazon.com/images/I/61wq4+PxvFL._SL1400_.jpg", true, "Back in Black", 39.99m, 8, "BCyBV6WJpTZcPG0b0WMfr8vJM1B3" },
                    { 11, 1, "Taylor Swift's 2019 album with pop anthems.", "https://m.media-amazon.com/images/I/81zWwCEXKPL._SL1500_.jpg", true, "Lover", 39.99m, 5, "l4XlJweAr3USaFL4DW3h2PfIqAC3" },
                    { 12, 1, "Taylor Swift's award-winning album from 2014.", "https://m.media-amazon.com/images/I/71r44eosF8L._SL1500_.jpg", true, "1989", 42.99m, 6, "LoBA4EB98KfPtTZ7t8hE2xlbURw1" },
                    { 13, 1, "Kacey Musgraves' Grammy-winning country album.", "https://m.media-amazon.com/images/I/81g8mMUxsnL._SL1500_.jpg", true, "Golden Hour", 35.99m, 4, "LoBA4EB98KfPtTZ7t8hE2xlbURw1" },
                    { 14, 1, "Taylor Swift's re-recorded classic country-pop album.", "https://m.media-amazon.com/images/I/81bIVb9zTxL._SL1500_.jpg", true, "Fearless (Taylor's Version)", 36.50m, 7, "LoBA4EB98KfPtTZ7t8hE2xlbURw1" },
                    { 15, 1, "Taylor Swift's re-recording of her hit album Speak Now.", "https://m.media-amazon.com/images/I/71qNte6mGBL._SL1500_.jpg", true, "Speak Now (Taylor's Version)", 45.99m, 3, "LoBA4EB98KfPtTZ7t8hE2xlbURw1" },
                    { 16, 1, "Folklore's sister album from Taylor Swift.", "https://m.media-amazon.com/images/I/71JJ0VdEP3L._SL1400_.jpg", true, "Evermore", 38.00m, 6, "LoBA4EB98KfPtTZ7t8hE2xlbURw1" },
                    { 17, 1, "Taylor Swift's highly anticipated 2022 album.", "https://m.media-amazon.com/images/I/71g2zPSy7cL._SL1500_.jpg", true, "Midnights", 39.50m, 5, "LoBA4EB98KfPtTZ7t8hE2xlbURw1" },
                    { 18, 1, "Indie-folk album from Taylor Swift featuring Bon Iver.", "https://m.media-amazon.com/images/I/71A8kMA6lsL._SL1500_.jpg", true, "Folklore", 37.99m, 4, "LoBA4EB98KfPtTZ7t8hE2xlbURw1" },
                    { 19, 1, "Taylor Swift's dark-pop comeback album.", "https://m.media-amazon.com/images/I/71-H5A-YxjL._SL1400_.jpg", true, "Reputation", 41.99m, 8, "LoBA4EB98KfPtTZ7t8hE2xlbURw1" },
                    { 20, 1, "Taylor Swift's iconic breakup album, re-recorded.", "https://m.media-amazon.com/images/I/61KtbxdHUtL._SL1500_.jpg", true, "Red (Taylor's Version)", 49.99m, 9, "LoBA4EB98KfPtTZ7t8hE2xlbURw1" },
                    { 21, 1, "The Doors' legendary debut album featuring 'Light My Fire'.", "https://m.media-amazon.com/images/I/81XwnMK0lnL._SL1500_.jpg", true, "The Doors", 28.99m, 6, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 22, 1, "U2's breakthrough album featuring 'With or Without You'.", "https://m.media-amazon.com/images/I/61Qx3-iADfL._SL1200_.jpg", true, "The Joshua Tree", 29.99m, 6, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 23, 1, "The Beatles' experimental classic from 1966.", "https://m.media-amazon.com/images/I/71-1XnQy3-L._SL1500_.jpg", true, "Revolver", 31.50m, 4, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 24, 1, "Queen's epic album featuring 'Bohemian Rhapsody'.", "https://m.media-amazon.com/images/I/71sN5JB01cL._SL1500_.jpg", true, "A Night at the Opera", 38.99m, 7, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 25, 1, "Jimi Hendrix's groundbreaking double album.", "https://m.media-amazon.com/images/I/71J07CmmyxL._SL1200_.jpg", true, "Electric Ladyland", 36.99m, 5, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 26, 1, "David Bowie's concept album featuring 'Starman'.", "https://m.media-amazon.com/images/I/81Ox3bH8K9L._SL1500_.jpg", true, "The Rise and Fall of Ziggy Stardust", 27.99m, 6, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 27, 1, "Dire Straits' biggest album featuring 'Money for Nothing'.", "https://m.media-amazon.com/images/I/71b6M0XLvSL._SL1500_.jpg", true, "Brothers in Arms", 32.99m, 5, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 28, 1, "Van Morrison’s most celebrated album, featuring 'Into the Mystic'.", "https://m.media-amazon.com/images/I/81Ug7cMZk8L._SL1500_.jpg", true, "Moondance", 31.99m, 5, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 29, 1, "A highly influential album with Andy Warhol's iconic banana cover.", "https://m.media-amazon.com/images/I/81vBx5EmKXL._SL1500_.jpg", true, "The Velvet Underground & Nico", 39.99m, 6, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 30, 1, "Another classic from David Bowie featuring 'Life on Mars?'.", "https://m.media-amazon.com/images/I/81a1DlQF7hL._SL1500_.jpg", true, "Hunky Dory", 30.99m, 7, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 31, 1, "The Clash's iconic punk rock double album.", "https://m.media-amazon.com/images/I/81AwUyc+KHL._SL1500_.jpg", true, "London Calling", 37.99m, 6, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 32, 1, "Prince's legendary album featuring 'When Doves Cry'.", "https://m.media-amazon.com/images/I/81TlfZbcY+L._SL1500_.jpg", true, "Purple Rain", 33.50m, 5, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 33, 1, "Bruce Springsteen's breakthrough album.", "https://m.media-amazon.com/images/I/91pGDOS2yYL._SL1500_.jpg", true, "Born to Run", 28.99m, 7, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 34, 1, "The Beach Boys' classic album that redefined pop music.", "https://m.media-amazon.com/images/I/81ZXxdrUwcL._SL1500_.jpg", true, "Pet Sounds", 36.99m, 5, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 35, 1, "Eagles' legendary album featuring the title track.", "https://m.media-amazon.com/images/I/71iCZPH5DqL._SL1500_.jpg", true, "Hotel California", 34.99m, 4, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 36, 1, "Carole King's masterpiece featuring 'You've Got a Friend'.", "https://m.media-amazon.com/images/I/91wPiHtmwQL._SL1500_.jpg", true, "Tapestry", 27.99m, 6, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 37, 1, "Simon & Garfunkel's classic folk-rock album.", "https://m.media-amazon.com/images/I/81KrqZuxNQL._SL1500_.jpg", true, "Bridge Over Troubled Water", 32.99m, 5, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 38, 1, "Curtis Mayfield's groundbreaking soul-funk album.", "https://m.media-amazon.com/images/I/91RCpMFXxQL._SL1500_.jpg", true, "Superfly", 31.50m, 4, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 39, 1, "Bob Dylan's deeply personal masterpiece.", "https://m.media-amazon.com/images/I/81DBw5cAzQL._SL1500_.jpg", true, "Blood on the Tracks", 35.50m, 6, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 40, 1, "The Beatles' final studio album.", "https://m.media-amazon.com/images/I/71qlM3JjXQL._SL1500_.jpg", true, "Let It Be", 30.99m, 7, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 41, 1, "Beastie Boys' genre-defining hip-hop album.", "https://m.media-amazon.com/images/I/91tZCYO2iIL._SL1500_.jpg", true, "Licensed to Ill", 27.99m, 5, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 42, 1, "The Smiths’ iconic post-punk album.", "https://m.media-amazon.com/images/I/81G7lzC5VLL._SL1500_.jpg", true, "The Queen Is Dead", 34.99m, 6, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 43, 1, "Red Hot Chili Peppers’ funk-rock breakthrough.", "https://m.media-amazon.com/images/I/71GywSYBKlL._SL1500_.jpg", true, "Blood Sugar Sex Magik", 33.50m, 4, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 44, 1, "R.E.M.'s critically acclaimed album.", "https://m.media-amazon.com/images/I/81wUOBjHboL._SL1500_.jpg", true, "Automatic for the People", 36.99m, 7, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 45, 1, "The Pixies’ alternative rock classic.", "https://m.media-amazon.com/images/I/81s6KZp1ajL._SL1500_.jpg", true, "Doolittle", 30.99m, 6, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 46, 1, "Patti Smith's influential punk album.", "https://m.media-amazon.com/images/I/81MbMS+FDsL._SL1500_.jpg", true, "Horses", 38.99m, 5, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 47, 1, "Guns N' Roses' explosive debut album.", "https://m.media-amazon.com/images/I/81pLDAZV4LL._SL1500_.jpg", true, "Appetite for Destruction", 29.99m, 5, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 48, 1, "Fleetwood Mac’s most celebrated album.", "https://m.media-amazon.com/images/I/81vw+8N6WQL._SL1500_.jpg", true, "Rumours", 35.99m, 7, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 49, 1, "AC/DC’s best-selling rock album of all time.", "https://m.media-amazon.com/images/I/81zBfuU6+RL._SL1500_.jpg", true, "Back in Black", 37.50m, 6, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 50, 1, "Metallica’s iconic thrash metal album.", "https://m.media-amazon.com/images/I/91zRVgJavIL._SL1500_.jpg", true, "Master of Puppets", 33.99m, 5, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" }
                });

            migrationBuilder.InsertData(
                table: "UserPaymentMethods",
                columns: new[] { "Id", "PaymentOptionId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "6Na5niFGCaUfZz7y9cjbFEq8twj1" },
                    { 2, 2, "6Na5niFGCaUfZz7y9cjbFEq8twj1" },
                    { 3, 3, "6Na5niFGCaUfZz7y9cjbFEq8twj1" },
                    { 4, 1, "l4XlJweAr3USaFL4DW3h2PfIqAC3" },
                    { 5, 2, "l4XlJweAr3USaFL4DW3h2PfIqAC3" },
                    { 6, 3, "l4XlJweAr3USaFL4DW3h2PfIqAC3" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "IsComplete", "OrderDate", "UserPaymentMethodId" },
                values: new object[,]
                {
                    { 1, "6Na5niFGCaUfZz7y9cjbFEq8twj1", false, new DateTime(2025, 3, 8, 20, 44, 14, 859, DateTimeKind.Utc).AddTicks(9160), 1 },
                    { 2, "6Na5niFGCaUfZz7y9cjbFEq8twj1", true, new DateTime(2025, 2, 26, 20, 44, 14, 859, DateTimeKind.Utc).AddTicks(9160), 2 },
                    { 3, "6Na5niFGCaUfZz7y9cjbFEq8twj1", true, new DateTime(2025, 2, 16, 20, 44, 14, 859, DateTimeKind.Utc).AddTicks(9170), 3 },
                    { 4, "l4XlJweAr3USaFL4DW3h2PfIqAC3", false, new DateTime(2025, 3, 8, 20, 44, 14, 859, DateTimeKind.Utc).AddTicks(9170), 4 },
                    { 5, "l4XlJweAr3USaFL4DW3h2PfIqAC3", true, new DateTime(2025, 3, 3, 20, 44, 14, 859, DateTimeKind.Utc).AddTicks(9170), 5 },
                    { 6, "l4XlJweAr3USaFL4DW3h2PfIqAC3", true, new DateTime(2025, 2, 21, 20, 44, 14, 859, DateTimeKind.Utc).AddTicks(9170), 6 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "SellerId" },
                values: new object[,]
                {
                    { 1, 1, 5, 2, "SellerA" },
                    { 2, 1, 8, 1, "SellerB" },
                    { 3, 2, 3, 3, "SellerC" },
                    { 4, 3, 10, 2, "SellerA" },
                    { 5, 4, 6, 4, "SellerB" },
                    { 6, 5, 7, 1, "SellerC" },
                    { 7, 5, 2, 2, "SellerA" },
                    { 8, 6, 9, 1, "SellerB" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserPaymentMethodId",
                table: "Orders",
                column: "UserPaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPaymentMethods_PaymentOptionId",
                table: "UserPaymentMethods",
                column: "PaymentOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPaymentMethods_UserId",
                table: "UserPaymentMethods",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UserPaymentMethods");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "PaymentOptions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
