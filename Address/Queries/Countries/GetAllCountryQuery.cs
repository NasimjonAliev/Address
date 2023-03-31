using Address.Context;
using Address.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Countries;

public class GetAllCountryQuery : IRequest<IEnumerable<Country>>
{
    public class GetAllCountryQueryHandler : IRequestHandler<GetAllCountryQuery, IEnumerable<Country>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllCountryQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Country>> Handle(GetAllCountryQuery query, CancellationToken cancellationToken)
        {
            var countryList = await _context.Countries.ToListAsync();
            return countryList;
        }
    }
}