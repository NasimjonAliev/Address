using Address.Context;
using Address.Entities;
using MediatR;

namespace Address.Commands.Streets;

public class CreateStreetCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Number { get; set; }
    public int CityId { get; set; }

    public class CreateStreetHandler : IRequestHandler<CreateStreetCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateStreetHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateStreetCommand command, CancellationToken cancellationToken)
        {
            var street = new Street()
            {
                Name = command.Name,
                Number = command.Number,
                CityId = command.CityId
            };

            _context.Streets.Add(street);
            await _context.SaveChangesAsync();
            return street.Id;
        }
    }
}

