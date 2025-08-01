using CustomerApi.Models;
 using Microsoft.EntityFrameworkCore;
 
namespace CustomerApi.Data {
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
    }
}