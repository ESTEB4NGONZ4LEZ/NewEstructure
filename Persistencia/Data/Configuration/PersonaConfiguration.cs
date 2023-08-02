
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("persona");

        builder.HasKey(a => a.IdPersona);
        builder.Property(a => a.IdPersona)
        .IsRequired();

        builder.Property(a => a.NombrePersona)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(a => a.ApellidoPersona)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(a => a.EdadPersona)
        .IsRequired();

        builder.HasOne(a => a.Provincia)
        .WithMany(e => e.Personas)
        .HasForeignKey(i => i.IdProvincia)
        .IsRequired();

        builder.HasOne(a => a.TipoPersona)
        .WithMany(e => e.Personas)
        .HasForeignKey(i => i.IdTipoPersona)
        .IsRequired();
    }
}
