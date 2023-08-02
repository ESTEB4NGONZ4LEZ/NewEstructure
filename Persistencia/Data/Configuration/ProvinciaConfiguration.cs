
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ProvinciaConfiguration : IEntityTypeConfiguration<Provincia>
{
    public void Configure(EntityTypeBuilder<Provincia> builder)
    {
        builder.ToTable("provincia");

        builder.HasKey(a => a.IdProvincia);
        builder.Property(a => a.IdProvincia)
        .IsRequired();

        builder.Property(a => a.NombreProvincia)
        .HasMaxLength(30)
        .IsRequired();

        builder.HasOne(a => a.Region)
        .WithMany(e => e.Provincias)
        .HasForeignKey(i => i.IdRegion)
        .IsRequired();
    }
}