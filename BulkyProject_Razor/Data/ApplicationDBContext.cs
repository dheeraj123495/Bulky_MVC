using BulkyProject_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyProject_Razor.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { id = 2, Name = "ScFI", DisplayOrder = 2 },
                new Category { id = 3, Name = "History", DisplayOrder = 3 }
                );
        }
    }
}
