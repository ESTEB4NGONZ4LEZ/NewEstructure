
namespace Dominio;

public class Region
{
    // * Atributos
    public int IdRegion { get; set; }
    public string NombreRegion { get; set; } = null!;
    public int IdPais { get; set; }
    // * ICollection
    public ICollection<Provincia>? Provincias { get; set; }
    // * Referencia a la Entidad
    public Pais? Pais { get; set; }
}
