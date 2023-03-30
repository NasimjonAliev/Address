using Address.Commands.Regions;
using Address.Entities;
using Address.Repositories.Regions;
using MediatR;

namespace Address.Handlers.Regions;

public class CreateRegionHandler : IRequestHandler<CreateRegionCommand, Region>
{
    private readonly IRegionRepository _regionRepository;

    public CreateRegionHandler(IRegionRepository regionRepository)
    {
        _regionRepository = regionRepository;
    }

    public async Task<Region> Handle(CreateRegionCommand command, CancellationToken cancellationToken)
    {
        var region = new Region()
        {
            Name = command.Name
        };

        return await _regionRepository.AddRegionAsync(region);
    }
}