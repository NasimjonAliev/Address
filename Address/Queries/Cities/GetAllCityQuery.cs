using Address.Context;
using Address.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Cities;

public class GetAllCityQuery : IRequest<IEnumerable<City>>
{
    public class GetAllCityQueryHandler : IRequestHandler<GetAllCityQuery, IEnumerable<City>>
    {
        private readonly ApplicationDbContext _context;
        
        public GetAllCityQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> Handle(GetAllCityQuery query, CancellationToken cancellationToken)
        {
            var cityList = await _context.Cities.ToListAsync();
            return cityList;
        }
    }
}
