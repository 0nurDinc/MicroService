using MicroService.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroService.Context
{
    public class AppDBContext:DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryID = 1,
                CategoryName = "Test",
                Description = "Test"
            });

            modelBuilder.Entity<Category>().HasData(new Category() { 
                CategoryID=2,
                CategoryName= "Test1",
                Description= "Test1"
            });

        }
    }

}
