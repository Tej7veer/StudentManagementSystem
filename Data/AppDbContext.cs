using Microsoft.EntityFrameworkCore;
using StudentManagementSystm.Models;

namespace StudentManagementSystm.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
            new Student { Id = 1, Name = "Alice Johnson", Email = "alice@example.com", Age = 21, Course = "Computer Science", CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
            new Student { Id = 2, Name = "Bob Smith", Email = "bob@example.com", Age = 22, Course = "Information Technology", CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
        );
    }
}
