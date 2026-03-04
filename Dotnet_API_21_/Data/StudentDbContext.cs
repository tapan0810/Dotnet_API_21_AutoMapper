using Dotnet_API_21_.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_21_.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Student> DbSet => Set<Student>();
    }
}
