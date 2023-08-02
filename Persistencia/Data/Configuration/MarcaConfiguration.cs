
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.ToTable("marca");

        builder.HasKey(a => a.IdMarca);
        builder.Property(a => a.IdMarca)
        .IsRequired();

        builder.Property(a => a.Descripcion)
        .HasColumnType("text");
    }
}
