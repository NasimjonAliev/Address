using Address.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Address.Configuration;

public class StreetConfiguration : IEntityTypeConfiguration<Street>
{
    public void Configure(EntityTypeBuilder<Street> builder)
    {
        builder.Property(t => t.Number)
            .HasMaxLength(15)
            .IsRequired();

        builder.HasOne(t => t.City)
            .WithMany(t => t.Streets)
            .HasForeignKey(s=>s.CityId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

        builder.HasIndex(s => s.Id);
    }
}

