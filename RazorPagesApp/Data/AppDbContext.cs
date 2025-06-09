using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<RadioProduct> RadioProducts { get; set; }
        public DbSet<DairyProduct> DairyProducts { get; set; }
        public DbSet<Transistor> Transistors { get; set; }
    }
}