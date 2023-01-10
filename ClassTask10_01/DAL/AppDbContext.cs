using ClassTask10_01.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassTask10_01.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
