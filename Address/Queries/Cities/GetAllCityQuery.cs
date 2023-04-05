using Address.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Cities;

public class GetAllCityQuery : IRequest<IEnumerable<GetAllCityViewModel>>
{
}

public class GetAllCityQueryHandler : IRequestHandler<GetAllCityQuery, IEnumerable<GetAllCityViewModel>>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllCityQueryHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetAllCityViewModel>> Handle(GetAllCityQuery query, CancellationToken cancellationToken)
    {
        var cityList = await _context.Cities.AsNoTracking()
            .ProjectTo<GetAllCityViewModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);

        return cityList;
    }
}
