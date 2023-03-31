using Address.Context;
using Address.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Streets;

public class GetAllStreetQuery : IRequest<IEnumerable<Street>>
{
    public class GetAllStreetQueryHandler : IRequestHandler<GetAllStreetQuery, IEnumerable<Street>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllStreetQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Street>> Handle(GetAllStreetQuery query, CancellationToken cancellationToken)
        {
            var street = await _context.Streets.ToListAsync();
            return street;
        }

    }
}
