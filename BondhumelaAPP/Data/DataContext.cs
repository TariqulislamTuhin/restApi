using BondhumelaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BondhumelaApp.Data {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}