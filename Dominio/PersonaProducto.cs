
namespace Dominio;

public class PersonaProducto
{
    public int IdPersona { get; set; }
    public int IdProducto { get; set; }
    public Persona? Persona { get; set; }
    public Producto? Producto { get; set; }
}
