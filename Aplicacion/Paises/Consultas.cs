
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Paises;

public class Consultas
{
    public class ListaPais : IRequest<List<Pais>>{}

    public class Manejador : IRequestHandler<ListaPais, List<Pais>>
    {
        private readonly NewEstructureContext context;

        public Manejador(NewEstructureContext _context)
        {
            context = _context;
        }

        public async Task<List<Pais>> Handle(ListaPais request, CancellationToken cancellationToken)
        {
            var paises = await context.Paises.ToListAsync();
            return paises;
        }
    }
}
