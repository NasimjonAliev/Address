using Address.Context;
using Address.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Cities;

public class GetCityByIdQuery : IRequest<City>
{
    public int Id { get; set; }

    public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, City>
    {
        private readonly ApplicationDbContext _context;

        public GetCityByIdQueryHandler (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<City> Handle (GetCityByIdQuery query, CancellationToken cancellationToken)
        {
            var city = await _context.Cities.Where(a => a.Id == query.Id).FirstOrDefaultAsync();

            return city;
        }
    } 
}
