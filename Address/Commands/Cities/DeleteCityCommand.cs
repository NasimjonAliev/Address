using Address.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Address.Commands.Cities;

public class DeleteCityCommand : IRequest<int>
{
    public int Id { get; set; }

    public class DeleteCityHandler : IRequestHandler<DeleteCityCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public DeleteCityHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteCityCommand command, CancellationToken cancellationToken)
        {
            var city = await _context.Cities.Where(a => a.Id == command.Id).FirstOrDefaultAsync();
            await _context.SaveChangesAsync();
            return command.Id;
        }
    }
}
