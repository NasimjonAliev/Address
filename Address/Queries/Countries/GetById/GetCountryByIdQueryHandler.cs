using Address.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Countries.GetCountryById;

public class GetCountryByIdQueryHandler : IRequestHandler<GetCountryByIdQuery, GetCountryByIdViewModel>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetCountryByIdQueryHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetCountryByIdViewModel> Handle(GetCountryByIdQuery query, CancellationToken cancellationToken)
    {
        var country = await _context.Countries.Where(a => a.Id == query.Id).AsNoTracking()
        .ProjectTo<GetCountryByIdViewModel>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(cancellationToken);

        return country;
    }
}
