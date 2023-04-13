using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Reaction", DisplayOrder = 3 },
                new Category { Id = 3, Name = "Wapsag", DisplayOrder = 5 },
                new Category { Id = 4, Name = "Nendag", DisplayOrder = 2 },
                new Category { Id = 5, Name = "Rawag", DisplayOrder = 4 }
                );
        }
    }
}
