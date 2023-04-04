using Address.Entities;
using Microsoft.EntityFrameworkCore;

namespace Address.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Street> Streets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("Host=localhost;Port=5432;Database=addressDb;Username=postgres;Password=root");
    }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
}
