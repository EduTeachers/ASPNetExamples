using Microsoft.EntityFrameworkCore;
using MySQLExample.Entities;

namespace MySQLExample;

public class ApplicationDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>()
            .HasKey(u => u.UserId);
    }
}