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
            //Seeding
            builder.Entity<Product>().HasData(
                new Product { Name = "Lavender Plant", Description = "Aromatic lavender plant with soothing fragrance.", Price = 9.99M },
                new Product { Name = "Rosemary Seeds", Description = "Organic rosemary seeds for home cultivation.", Price = 4.99M },
                new Product { Name = "Mint Tea Bags", Description = "Premium mint tea bags for a refreshing beverage.", Price = 7.99M },
                new Product { Name = "Basil Potted Plant", Description = "Fresh basil plant for culinary use.", Price = 5.99M },
                new Product { Name = "Chamomile Flowers", Description = "Dried chamomile flowers for herbal infusions.", Price = 12.99M },
                new Product { Name = "Thyme Essential Oil", Description = "Pure thyme essential oil for aromatherapy.", Price = 14.99M },
                new Product { Name = "Sage Leaves", Description = "Culinary sage leaves for seasoning dishes.", Price = 3.99M },
                new Product { Name = "Organic Turmeric Powder", Description = "High-quality organic turmeric powder.", Price = 8.99M },
                new Product { Name = "Echinacea Plant", Description = "Echinacea plant known for immune-boosting properties.", Price = 6.99M },
                new Product { Name = "Cilantro Seeds", Description = "Cilantro seeds for growing fresh cilantro at home.", Price = 2.99M }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
    }
}