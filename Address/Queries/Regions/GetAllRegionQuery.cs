using Address.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Regions;

public class GetAllRegionQuery : IRequest<IEnumerable<GetAllRegionViewModel>>
{
}

public class GetAllRegionQueryHandler : IRequestHandler<GetAllRegionQuery, IEnumerable<GetAllRegionViewModel>>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllRegionQueryHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetAllRegionViewModel>> Handle(GetAllRegionQuery query, CancellationToken cancellationToken)
    {
        var region = await _context.Regions.AsNoTracking()
            .ProjectTo<GetAllRegionViewModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);

        return region;
    }
}


