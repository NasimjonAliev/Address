using Address.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Streets.GetStreetById;

public class GetStreetByIdHandler : IRequestHandler<GetStreetByIdQuery, GetStreetByIdViewModel>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetStreetByIdHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetStreetByIdViewModel> Handle(GetStreetByIdQuery query, CancellationToken cancellationToken)
    {
        var street = await _context.Streets.Where(a => a.Id == query.Id).AsNoTracking()
            .ProjectTo<GetStreetByIdViewModel>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(cancellationToken);

        return street;
    }
}
