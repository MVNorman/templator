using Domain;
using Infrastructure.Ef.ModelBuilders;
using Microsoft.EntityFrameworkCore;

#pragma warning disable CS8618

namespace Infrastructure.Ef;

public class OperationalContext : DbContext
{
    public const string Name = "Operational";

    public DbSet<User> Users { get; set; }

    public OperationalContext(DbContextOptions<OperationalContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.BuildUsers();
    }
}