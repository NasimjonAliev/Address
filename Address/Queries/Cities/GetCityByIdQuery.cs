using Address.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Cities;

public class GetCityByIdQuery : IRequest<GetCityByIdViewModel>
{
    public int Id { get; set; }
}

public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, GetCityByIdViewModel>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetCityByIdQueryHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetCityByIdViewModel> Handle(GetCityByIdQuery query, CancellationToken cancellationToken)
    {
        var city = await _context.Cities.Where(a => a.Id == query.Id).AsNoTracking()
            .ProjectTo<GetCityByIdViewModel>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(cancellationToken);

        return city;
    }
}
