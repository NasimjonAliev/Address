using Address.Context;
using Address.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Countries;

public class GetCountryByIdQuery : IRequest<Country>
{
    public int Id { get; set; }
    public class GetCountryByIdQueryHandler : IRequestHandler<GetCountryByIdQuery, Country>
    {
        private readonly ApplicationDbContext _context;

        public GetCountryByIdQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Country> Handle(GetCountryByIdQuery query, CancellationToken cancellationToken)
        {
            var country = await _context.Countries.Where(a => a.Id == query.Id).FirstOrDefaultAsync();

            return country;
        }
    }
}
