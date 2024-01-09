using Microsoft.AspNetCore.Identity;

namespace EcoHerbalist.Data.DbModels
{
    public class OrderDetails
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalPriceWithVAT { get; set; }
        public IdentityUser User { get; set; }
        public Product Product { get; set; }
    }
}
