using Address.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Commands.Regions;

public class DeleteRegionCommand : IRequest<int>
{
    public int Id { get; set; }

    public class DeleteRegionHandler : IRequestHandler<DeleteRegionCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public DeleteRegionHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteRegionCommand command, CancellationToken cancellationToken)
        {
            var region = await _context.Regions.Where(a => a.Id == command.Id).FirstOrDefaultAsync();

            _context.Regions.Remove(region);

            await _context.SaveChangesAsync();

            return region.Id;
        }
    }
}

