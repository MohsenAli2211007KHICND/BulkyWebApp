using BulkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebRazor_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action1", DisplayOrder=1 },
                new Category { Id = 2, Name = "Action2", DisplayOrder = 5 },
                new Category { Id = 3, Name = "Action3", DisplayOrder = 6 },
                new Category { Id = 4, Name = "Action4", DisplayOrder = 3 },
                new Category { Id = 5, Name = "Action5", DisplayOrder = 2 },
                new Category { Id = 6, Name = "Action6", DisplayOrder = 4 }
                );
        }
    }
}
