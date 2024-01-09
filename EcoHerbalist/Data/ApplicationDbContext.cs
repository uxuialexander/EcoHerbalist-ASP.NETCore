using EcoHerbalist.Data.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Emit;

namespace EcoHerbalist.Data
{
    public class EcoHerbalistContext : IdentityDbContext<IdentityUser>
    {
        public EcoHerbalistContext(DbContextOptions<EcoHerbalistContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ProductCategories>()
                .HasNoKey();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
    }
}