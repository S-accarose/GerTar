using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GerTar.Models;

namespace GerTar.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Tipo> Tipos { get; set; } = null!;
    public DbSet<Tarefa> Tarefas { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Fix for MySQL: set key column lengths for Identity tables
        builder.Entity<Microsoft.AspNetCore.Identity.IdentityUser>(entity =>
        {
            entity.Property(m => m.Id).HasMaxLength(255);
        });
        builder.Entity<Microsoft.AspNetCore.Identity.IdentityRole>(entity =>
        {
            entity.Property(m => m.Id).HasMaxLength(255);
        });
        builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserLogin<string>>(entity =>
        {
            entity.Property(m => m.LoginProvider).HasMaxLength(255);
            entity.Property(m => m.ProviderKey).HasMaxLength(255);
        });
        builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserRole<string>>(entity =>
        {
            entity.Property(m => m.UserId).HasMaxLength(255);
            entity.Property(m => m.RoleId).HasMaxLength(255);
        });
        builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserToken<string>>(entity =>
        {
            entity.Property(m => m.UserId).HasMaxLength(255);
            entity.Property(m => m.LoginProvider).HasMaxLength(255);
            entity.Property(m => m.Name).HasMaxLength(255);
        });
        builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserClaim<string>>(entity =>
        {
            entity.Property(m => m.Id).HasMaxLength(255);
            entity.Property(m => m.UserId).HasMaxLength(255);
        });
        builder.Entity<Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>>(entity =>
        {
            entity.Property(m => m.Id).HasMaxLength(255);
            entity.Property(m => m.RoleId).HasMaxLength(255);
        });
    }
}
