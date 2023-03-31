using Address.Context;
using Address.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Queries.Streets;

public class GetStreetByIdQuery : IRequest<Street>
{
    public int Id { get; set; }

    public class GetStreetByIdHandler : IRequestHandler<GetStreetByIdQuery, Street>
    {
        private readonly ApplicationDbContext _context;

        public GetStreetByIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Street> Handle(GetStreetByIdQuery query, CancellationToken cancellationToken)
        {
            var street = await _context.Streets.Where(a => a.Id == query.Id).FirstOrDefaultAsync();

            return street;
        }
    }
}