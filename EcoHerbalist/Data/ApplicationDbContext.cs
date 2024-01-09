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
            builder.Entity<Product>()
                .HasData(
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

            //seed admin and user roles

            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole
                {
                    Name = "SuperAdmin",
                    NormalizedName = "SUPERADMIN",
                    Id = ADMIN_ROLE_ID,
                    ConcurrencyStamp = ADMIN_ROLE_ID
                }, new IdentityRole
                {
                    Name = "user",
                    NormalizedName = "user",
                    Id = USER_ROLE_ID,
                    ConcurrencyStamp = USER_ROLE_ID
                });


            //seed user
            var users = SeedUsers();
            builder.Entity<IdentityUser>().HasData(users);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>()
                .HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ROLE_ID,
                    UserId = users.FirstOrDefault(u => u.UserName == "admin@admin.bg")?.Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = users.FirstOrDefault(u => u.UserName == "user@user.bg")?.Id
                }); ;

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }

        private IEnumerable<IdentityUser> SeedUsers()
        {

           var adminUser =  new IdentityUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = "admin@admin.bg",
                    EmailConfirmed = true,
                    UserName = "admin@admin.bg",
                    NormalizedUserName = "ADMIN@ADMIN.BG",
                };
        
            //set user password
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            adminUser.PasswordHash = ph.HashPassword(adminUser, "testApi!@#123");

            var normalUser = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "user@user.bg",
                EmailConfirmed = true,
                UserName = "user@user.bg",
                NormalizedUserName = "USER@USER.BG",
            };

            //set user password
            normalUser.PasswordHash = ph.HashPassword(normalUser, "testApiUser!@#123");

            return new List<IdentityUser> { adminUser, normalUser };
        }
    }
}