
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
        builder.ToTable("tipo_persona");

        builder.HasKey(a => a.IdTipoPersona);
        builder.Property(a => a.IdTipoPersona)
        .IsRequired();

        builder.Property(a => a.Descripcion)
        .HasColumnType("text");
    }
}