
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("region");

        builder.HasKey(a => a.IdRegion);
        builder.Property(a => a.IdRegion)
        .IsRequired();

        builder.Property(a => a.NombreRegion)
        .HasMaxLength(30)
        .IsRequired();

        builder.HasOne(a => a.Pais)
        .WithMany(e => e.Regiones)
        .HasForeignKey(i => i.IdPais)
        .IsRequired();
    }
}