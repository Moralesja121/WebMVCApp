using Microsoft.EntityFrameworkCore;
using WebMVCApp.Models;

namespace WebMVCApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) // Required for all database interactions
        {
        }

        public DbSet<Category> Categories { get; set; } // Sets Table name in database for the Category model
    }
}
