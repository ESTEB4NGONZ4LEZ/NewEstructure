
using Microsoft.EntityFrameworkCore;

namespace Persistencia;

public class NewEstructureContext : DbContext
{
    public NewEstructureContext(DbContextOptions<NewEstructureContext> options) : base(options)
    {
    }
    
}
