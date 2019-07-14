using Microsoft.EntityFrameworkCore;
using shoppinglistapi.Models;

namespace shoppinglistapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<ShoppingList> ShoppingList { get; set; }
        public DbSet<Store> Store { get; set; }

    }
}