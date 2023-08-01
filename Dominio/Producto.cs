
namespace Dominio;

public class Producto
{
    // * Atributos
    public int IdProducto { get; set; }
    public string RefProducto { get; set; } = null!;
    public string? DescripcionProducto { get; set; }
    public double PrecioProducto { get; set; }
    public double DctoProducto { get; set; }
    public int IdMarca { get; set; }
    // * ICollection
    public ICollection<PersonaProducto>? PersonaProductos { get; set; }
    // * Referencia a la Entidad
    public Marca? Marca { get; set; }
}
