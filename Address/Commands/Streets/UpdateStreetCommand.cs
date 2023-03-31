using Address.Context;
using MediatR;

namespace Address.Commands.Streets;

public class UpdateStreetCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }

    public class UpdateStreetHandler : IRequestHandler<UpdateStreetCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public UpdateStreetHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateStreetCommand command, CancellationToken cancellationToken)
        {
            var street = _context.Streets.Where(a => a.Id == command.Id).FirstOrDefault();

            if (street == null)
                return default;

            street.Name = command.Name;
            street.Number = command.Number;

            await _context.SaveChangesAsync();

            return street.Id;
        }
    }
}
