using Address.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Regions.GetRegionById;

public class GetRegionByIdHandler : IRequestHandler<GetRegionByIdQuery, GetRegionByIdViewModel>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetRegionByIdHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetRegionByIdViewModel> Handle(GetRegionByIdQuery query, CancellationToken cancellationToken)
    {
        var region = await _context.Regions.Where(a => a.Id == query.Id).AsNoTracking()
            .ProjectTo<GetRegionByIdViewModel>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(cancellationToken);

        return region;
    }
}
