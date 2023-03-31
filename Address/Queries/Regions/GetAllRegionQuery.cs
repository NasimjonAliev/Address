using Address.Context;
using Address.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Regions;

public class GetAllRegionQuery : IRequest<List<Region>>
{
    public class GetAllRegionQueryHandler : IRequestHandler<GetAllRegionQuery, IEnumerable<Region>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllRegionQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Region>> Handle(GetAllRegionQuery query, CancellationToken cancellationToken)
        {
            var region = await _context.Regions.ToListAsync();

            return region;
        }
    }
}


