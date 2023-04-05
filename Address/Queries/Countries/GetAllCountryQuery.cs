using Address.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Countries;

public class GetAllCountryQuery : IRequest<IEnumerable<GetAllCountryViewModel>>
{
}
public class GetAllCountryQueryHandler : IRequestHandler<GetAllCountryQuery, IEnumerable<GetAllCountryViewModel>>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllCountryQueryHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetAllCountryViewModel>> Handle(GetAllCountryQuery query, CancellationToken cancellationToken)
    {
        var countryList = await _context.Countries.AsNoTracking()
            .ProjectTo<GetAllCountryViewModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
       
        return  countryList;
    }
}