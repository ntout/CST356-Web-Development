using Microsoft.EntityFrameworkCore;

namespace database
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)         
        {         
        }
        
        public DbSet<Student> Student { get; set; }
        public DbSet<Student> Instructor { get; set; }
    }
}