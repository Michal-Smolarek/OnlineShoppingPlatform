using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace OnlineShoppingPlatform.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Bluzy" },
                new Category() { Id = 2, Name = "Koszulki" },
                new Category() { Id = 3, Name = "Dodatki" }
                );

            modelBuilder.Entity<Product>().HasData(                        
                new Product { ProductId = 1, Name = "Bluza z kapturem", CategoryId = 1, Description = "Ciepła bluza z kapturem", Price = 149.99, IsAvaliable = true },
                new Product { ProductId = 2, Name = "Bluza oversize", CategoryId = 1, Description = "Luźna bluza unisex", Price = 129.99, IsAvaliable = true },
                new Product { ProductId = 3, Name = "Koszulka basic", CategoryId = 2, Description = "Prosta koszulka bawełniana", Price = 49.99, IsAvaliable = true },
                new Product { ProductId = 4, Name = "Koszulka sportowa", CategoryId = 2, Description = "Oddychająca koszulka na siłownię", Price = 69.99, IsAvaliable = true },
                new Product { ProductId = 5, Name = "Czapka z daszkiem", CategoryId = 3, Description = "Stylowa czapka na lato", Price = 39.99, IsAvaliable = true },
                new Product { ProductId = 6, Name = "Skarpetki kolorowe", CategoryId = 3, Description = "Zestaw 3 par skarpet w różnych wzorach", Price = 29.99, IsAvaliable = true },
                new Product { ProductId = 7, Name = "Bluza z nadrukiem", CategoryId = 1, Description = "Modna bluza z unikalnym wzorem", Price = 159.99, IsAvaliable = true },
            new Product { ProductId = 8, Name = "Bluza polarowa", CategoryId = 1, Description = "Miękka bluza z polaru", Price = 179.99, IsAvaliable = true },
            new Product { ProductId = 9, Name = "Koszulka premium", CategoryId = 2, Description = "Wysokiej jakości koszulka bawełniana", Price = 89.99, IsAvaliable = true },
            new Product { ProductId = 10, Name = "Koszulka z grafiką", CategoryId = 2, Description = "Koszulka z designerskim nadrukiem", Price = 59.99, IsAvaliable = true },
            new Product { ProductId = 11, Name = "Plecak sportowy", CategoryId = 3, Description = "Lekki i pojemny plecak", Price = 99.99, IsAvaliable = true },
            new Product { ProductId = 12, Name = "Saszetka na pas", CategoryId = 3, Description = "Praktyczna nerka na pas", Price = 79.99, IsAvaliable = true },
            new Product { ProductId = 13, Name = "Rękawiczki zimowe", CategoryId = 3, Description = "Ciepłe rękawiczki na chłodne dni", Price = 49.99, IsAvaliable = true },
            new Product { ProductId = 14, Name = "Koszulka termoaktywna", CategoryId = 2, Description = "Idealna na aktywność fizyczną", Price = 99.99, IsAvaliable = true },
            new Product { ProductId = 15, Name = "Bluza sportowa", CategoryId = 1, Description = "Wygodna bluza do treningu", Price = 139.99, IsAvaliable = true }
                );
        }
    }
}
