using Address.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Address.Configuration;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.Property(t => t.Code)
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(c => c.Area)
            .HasMaxLength(10);

        builder.Property(c => c.Type)
            .HasMaxLength(10);

        builder.Property(c => c.Population)
            .HasMaxLength(30)
            .IsRequired();

        builder.HasIndex(t => t.Code);
    }
}

