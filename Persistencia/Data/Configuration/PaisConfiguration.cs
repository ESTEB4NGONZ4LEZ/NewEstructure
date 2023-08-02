
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("pais");

        builder.HasKey(a => a.IdPais);
        builder.Property(a => a.IdPais)
        .IsRequired();
        
        builder.Property(a => a.NombrePais)
        .HasMaxLength(30)
        .IsRequired();
    }
}
