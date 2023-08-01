
namespace Dominio;

public class Persona
{
    // * Atributos 
    public int IdPersona { get; set; }
    public string NombrePersona { get; set; } = null!;
    public string ApellidoPersona { get; set; } = null!;
    public int EdadPersona { get; set; }    
    public int IdProvincia { get; set; }
    public int IdTipoPersona { get; set; }
    // * ICollection
    public ICollection<PersonaProducto>? PersonaProductos { get; set; }
    // * Referencia a la Entidad
    public Provincia? Provincia { get; set; }
    public TipoPersona? TipoPersona { get; set; }
}
