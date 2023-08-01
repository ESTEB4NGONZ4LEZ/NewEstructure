
namespace Dominio;

public class Pais
{
    // * Atributos
    public int IdPais { get; set; }
    public string NombrePais { get; set; } = null!;
    // * ICollection
    public ICollection<Region>? Regiones { get; set; }
}
