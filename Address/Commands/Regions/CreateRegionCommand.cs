using Address.Context;
using Address.Entities;
using MediatR;

namespace Address.Commands.Regions;

public class CreateRegionCommand : IRequest<int>
{
    public string Name { get; set; }
    public string DistrictName { get; set; }
    public int CountyId { get; set; }

    public class CreateRegionHandler : IRequestHandler<CreateRegionCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateRegionHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateRegionCommand command, CancellationToken cancellationToken)
        {
            var region = new Region()
            {
                Name = command.Name,
                DistrictName = command.DistrictName,
                CountryId = command.CountyId
            };

            _context.Regions.Add(region);
            await _context.SaveChangesAsync();
            return region.Id;
        }
    }
}