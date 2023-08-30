using Microsoft.EntityFrameworkCore;

namespace Student_API.Models
{
    public class APPDbContext : DbContext
    {
        
        public APPDbContext(DbContextOptions<APPDbContext> options):base(options) { }

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);
         }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public  DbSet<Student> Student { get; set; }

        public  DbSet<Department> Department { get; set; }
    }
}
