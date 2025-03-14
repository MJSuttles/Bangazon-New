// using System.ComponentModel.DataAnnotations;
// using System.Collections.Generic;

// namespace Bangazon.Models;

// public class UserPaymentMethod
// {
//   [Key]
//   public string Uid { get; set; }  // ✅ Firebase UID as primary key

//   public string FirstName { get; set; }
//   public string LastName { get; set; }
//   public string Email { get; set; }
//   public string Address { get; set; }
//   public string City { get; set; }
//   public string State { get; set; }
//   public string Zip { get; set; }

//   public List<Order> Orders { get; set; } = new List<Order>();  // ✅ Ensure non-null List
//   public List<UserPaymentMethod> UserPaymentMethods { get; set; } = new List<UserPaymentMethod>();
// }

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bangazon.Models;

public class UserPaymentMethod
{
  [Key]
  public int Id { get; set; }  // ✅ Primary key for UserPaymentMethod

  [Required]
  public string UserId { get; set; }  // ✅ Must match User.Uid

  [ForeignKey("UserId")]
  public User User { get; set; }  // ✅ Relationship to User

  public int PaymentOptionId { get; set; }  // ✅ Must match PaymentOption.Id

  [ForeignKey("PaymentOptionId")]
  public PaymentOption PaymentOption { get; set; }  // ✅ Relationship to PaymentOption
}
