
namespace Dominio;

public class Marca
{
    // * Atributos
    public int IdMarca { get; set; }
    public string? Descripcion { get; set; }
    // * ICollection
    public ICollection<Producto>? Productos { get; set; }
}
