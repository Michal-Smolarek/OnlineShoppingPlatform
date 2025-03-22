using Microsoft.EntityFrameworkCore;

namespace OnlineShoppingPlatform.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}
        
    }
}
