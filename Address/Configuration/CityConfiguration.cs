using Address.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Address.Configuration;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.Property(t => t.PostIndex)
            .HasMaxLength(10)
            .IsRequired();

        builder.HasOne(c => c.Region)
            .WithMany(r => r.Cities)
            .HasForeignKey(r=> r.RegionId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

        builder.HasIndex(c => c.PostIndex);
    }
}
