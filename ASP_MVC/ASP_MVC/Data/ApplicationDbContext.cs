using ASP_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options) 
        {

        }
     
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(

                new Category { Id = 1, Name="Action"},
                new Category { Id = 2, Name="Scrifi" },
                new Category { Id = 3 , Name = "History"}
                );
        }
    }
}
