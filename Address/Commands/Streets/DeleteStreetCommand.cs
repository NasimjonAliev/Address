using Address.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Commands.Streets;

public class DeleteStreetCommand : IRequest<int>
{
    public int Id { get; set; }

    public class DeleteStreetHandler : IRequestHandler<DeleteStreetCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public DeleteStreetHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteStreetCommand command, CancellationToken cancellationToken)
        {
            var street = await _context.Streets.Where(a => a.Id == command.Id).FirstOrDefaultAsync();

            _context.Streets.Remove(street);

            await _context.SaveChangesAsync();

            return street.Id;
        }
    }
}


