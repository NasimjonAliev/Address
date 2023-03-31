using Address.Context;
using Address.Models;
using MediatR;

namespace Address.Commands.Countries;

public class CreateCountryCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string Area { get; set; }
    public string Population { get; set; }
    public string Mainland { get; set; }
    public string Type { get; set; }

    public class CreateCountryHandler : IRequestHandler<CreateCountryCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateCountryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateCountryCommand command, CancellationToken cancellationToken)
        {
            var country = new Country()
            {
                Name = command.Name,
                Code = command.Code,
                Area = command.Area,
                Population = command.Population,
                Mainland = command.Mainland,
                Type = command.Type
            };
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
            return country.Id;
        }
    }
}

