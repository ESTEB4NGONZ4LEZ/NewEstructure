
using System.Reflection;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;

public class NewEstructureContext : DbContext
{
    public NewEstructureContext(DbContextOptions<NewEstructureContext> options) : base(options)
    {
    }
    // ----- DbSet de las Entidades -----
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<PersonaProducto> PersonaProductos { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Provincia> Provincias { get; set; }
    public DbSet<Region> Regiones { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set; }
    // ----- Carga Automatica de las Configuraciones -----
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Tabla intermedio entre persona y producto
        modelBuilder.Entity<PersonaProducto>().HasKey(a => new { a.IdPersona, a.IdProducto });
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
