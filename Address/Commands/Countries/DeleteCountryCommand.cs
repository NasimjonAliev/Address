using Address.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Commands.Countries;

public class DeleteCountryCommand : IRequest<int>
{
    public int Id { get; set; }
}

public class DeleteCountryHandler : IRequestHandler<DeleteCountryCommand, int>
{
    private readonly ApplicationDbContext _context;

    public DeleteCountryHandler(ApplicationDbContext context)
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
