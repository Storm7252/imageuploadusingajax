using ajax_form_and_validation.Models;
using Microsoft.EntityFrameworkCore;

namespace ajax_form_and_validation.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions opt):base(opt)
        {
            
        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           /* modelBuilder.Entity<Student>().HasData(
                new Student() { Id = 1,Name="Danish",Age=26,Address="kunzer" },
                new Student() { Id = 2,Name="Umer ",Age=24,Address="srg" }
                );*/
        }
    }
}
