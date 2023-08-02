
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("producto");

        builder.HasKey(a => a.IdProducto);
        builder.Property(a => a.IdProducto)
        .IsRequired();

        builder.Property(a => a.RefProducto)
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(a => a.DescripcionProducto)
        .HasColumnType("text")
        .IsRequired();

        builder.Property(a => a.PrecioProducto)
        .HasColumnType("double")
        .IsRequired();

        builder.Property(a => a.DctoProducto)
        .HasColumnType("double")
        .IsRequired();

        builder.HasOne(a => a.Marca)
        .WithMany(e => e.Productos)
        .HasForeignKey(i => i.IdMarca)
        .IsRequired();
    }
}
