using Microsoft.EntityFrameworkCore;
using WebApplication13.Models;

namespace WebApplication13.Data // Make sure this matches your project's namespace
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
