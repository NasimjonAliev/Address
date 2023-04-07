using Address.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Address.Configuration;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.HasOne(x => x.Country)
                .WithMany(r => r.Regions)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

        builder.HasIndex(c => c.Id);
    }
}
