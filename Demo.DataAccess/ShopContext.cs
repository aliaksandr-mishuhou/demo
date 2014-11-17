using System.Data.Entity;
using Demo.Entities;

namespace Demo.DataAccess
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("name=ShopContext")
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
