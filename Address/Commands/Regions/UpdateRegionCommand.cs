using Address.Context;
using MediatR;

namespace Address.Commands.Regions;

public class UpdateRegionCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string DistrictName { get; set; }

    public class UpdateRegionHandler : IRequestHandler<UpdateRegionCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public UpdateRegionHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateRegionCommand command, CancellationToken cancellationToken)
        {
            var region = _context.Regions.Where(a => a.Id == command.Id).FirstOrDefault();     

            if (region == null)
                return default;

            region.Name = command.Name;
            region.DistrictName = command.DistrictName;
            await _context.SaveChangesAsync();

            return region.Id;
        }
    }
}

