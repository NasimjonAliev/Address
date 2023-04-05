using Address.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Streets;

public class GetAllStreetQuery : IRequest<IEnumerable<GetAllStreetViewModel>>
{
}

public class GetAllStreetQueryHandler : IRequestHandler<GetAllStreetQuery, IEnumerable<GetAllStreetViewModel>>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllStreetQueryHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetAllStreetViewModel>> Handle(GetAllStreetQuery query, CancellationToken cancellationToken)
    {
        var street = await _context.Streets.AsNoTracking()
            .ProjectTo<GetAllStreetViewModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);

        return street;
    }

}
