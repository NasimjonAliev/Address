using Address.Context;
using MediatR;

namespace Address.Commands.Cities;

public class UpdateCityCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public uint PostIndex { get; set; }

    public class UpdateCityHandler : IRequestHandler<UpdateCityCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public UpdateCityHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateCityCommand command, CancellationToken cancellationToken)
        {
            var city = _context.Cities.Where(a => a.Id == command.Id).FirstOrDefault();
            if (city == null)
                return default;

            city.Name = command.Name;
            city.PostIndex = command.PostIndex;
            await _context.SaveChangesAsync();

            return city.Id;
        }
    }
}
