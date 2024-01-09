using Microsoft.AspNetCore.Identity;

namespace EcoHerbalist.Data.DbModels
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
