using Address.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Commands.Regions.DeleteRegion;

public class DeleteRegionCommandHandler : IRequestHandler<DeleteRegionCommand, int>
{
    private readonly ApplicationDbContext _context;

    public DeleteRegionCommandHandler(ApplicationDbContext context)
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
