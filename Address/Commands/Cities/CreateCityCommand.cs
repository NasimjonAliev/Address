using Address.Context;
using Address.Entities;
using MediatR;

namespace Address.Commands.Cities;

public class CreateCityCommand : IRequest<int>
{
    public string Name { get; set; }
    public uint PostIndex { get; set; }
    public int RegionId { get; set; }

    public class CreateCityHandler : IRequestHandler<CreateCityCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateCityHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateCityCommand command, CancellationToken cancellationToken)
        {
            var city = new City();

            city.Name = command.Name;
            city.PostIndex = command.PostIndex;
            city.RegionId = command.RegionId;

            _context.Cities.Add(city);
            await _context.SaveChangesAsync();
            return city.Id;
        }
    }
}
