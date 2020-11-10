using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> products { set; get; }
        public DbSet<Category> categories { set; get; }

        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Quần" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Áo" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Giày" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, CategoryName = "Phụ kiện" });

            modelBuilder.Entity<Product>().HasData(new Product

            {
                Id = 1,
                Name = "Sơ Mi",
                Price = 35.4,
                Despition = "Sơ mi được nhập khẩu từ Cambodia",
                Count = 3,
                Color = "Trắng",
                CategoryId = 2,
            });
            modelBuilder.Entity<Product>().HasData(new Product

            {
                Id = 2,
                Name = "Jeans rách",
                Price = 50.5,
                Despition = "Jeans được nhập khẩu từ Laos",
                Count = 2,
                Color = "Xám",
                CategoryId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product

            {
                Id = 3,
                Name = "Kính râm",
                Price = 65.4,
                Despition = "Kính được nhập khẩu từ Brunei",
                Count = 5,
                Color = "Nâu",
                CategoryId = 4,
            });
            modelBuilder.Entity<Product>().HasData(new Product

            {
                Id = 4,
                Name = "Giày vans",
                Price = 65.4,
                Despition = "Giày được nhập khẩu từ Lào Cai",
                Count = 3,
                Color = "Xanh",
                CategoryId = 3,
            });
        }
    }
}
