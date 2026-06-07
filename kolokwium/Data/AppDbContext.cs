using kolokwium.Entities;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.Data;

public class AppDbContext: DbContext
{
    protected AppDbContext()
    {
    }
    
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Enrollment> Enrollments => Set<Enrollment>();
    public DbSet<Professor> Professors => Set<Professor>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}