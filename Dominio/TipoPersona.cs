
namespace Dominio;

public class TipoPersona
{
    // * Atributos
    public int IdTipoPersona { get; set; }
    public string? Descripcion { get; set; }
    // * ICollection
    public ICollection<Persona>? Personas { get; set; }
}
