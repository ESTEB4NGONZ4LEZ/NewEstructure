
namespace Dominio;

public class Provincia
{
    // * Atributos
    public int IdProvincia { get; set; }
    public string NombreProvincia { get; set; } = null!;
    public int IdRegion { get; set; }
    // * ICollection
    public ICollection<Persona>? Personas { get; set; }
    // * Referencia a la Entidad
    public Region? Region { get; set; }
}
