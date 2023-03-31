using Address.Context;
using Address.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Regions;

public class GetRegionByIdQuery : IRequest<Region>
{
    public int Id { get; set; }

    public class GetRegionByIdHandler : IRequestHandler<GetRegionByIdQuery, Region>
    {
        private readonly ApplicationDbContext _context;

        public GetRegionByIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Region> Handle(GetRegionByIdQuery query, CancellationToken cancellationToken)
        {
            var region = await _context.Regions.Where(a => a.Id == query.Id).FirstOrDefaultAsync();

            return region;
        }
    }
}