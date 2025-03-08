using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

using Bangazon.Models;

public class Category
{
  public int Id { get; set; }
  public string Title { get; set; }
  public List<Product> Products { get; set; }
}
