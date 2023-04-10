using Address.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Commands.Countries.DeleteCountry;

public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand, int>
{
    private readonly ApplicationDbContext _context;

    public DeleteCountryCommandHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(DeleteCountryCommand command, CancellationToken cancellationToken)
    {
        var country = await _context.Countries.Where(a => a.Id == command.Id).FirstOrDefaultAsync();

        _context.Countries.Remove(country);

        await _context.SaveChangesAsync();

        return country.Id;
    }
}
