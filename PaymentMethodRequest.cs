namespace Bangazon.Models
{
    public class PaymentMethodRequest
    {
        public string UserId { get; set; } = string.Empty;
        public int PaymentMethodId { get; set; }
    }
}
