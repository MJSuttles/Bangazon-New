using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Bangazon.Models;

public class AddToCartRequest
{
  public string UserId { get; set; } = "";
  public int ProductId { get; set; }
  public int Quantity { get; set; }
}
