using Address.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Commands.Streets.DeleteStreet;

public class DeleteStreetCoomandHandler : IRequestHandler<DeleteStreetCommand, int>
{
    private readonly ApplicationDbContext _context;

    public DeleteStreetCoomandHandler(ApplicationDbContext context)
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
