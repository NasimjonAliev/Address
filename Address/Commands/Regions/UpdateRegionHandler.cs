using Address.Commands.Regions;
using Address.Repositories.Regions;
using MediatR;

namespace Address.Handlers.Regions;

public class UpdateRegionHandler : IRequestHandler<UpdateRegionCommand, int>
{
    private readonly IRegionRepository _regionRepository;

    public UpdateRegionHandler(IRegionRepository regionRepository)
    {
        _regionRepository = regionRepository;
    }

    public async Task<int> Handle(UpdateRegionCommand command, CancellationToken cancellationToken)
    {
        var region = await _regionRepository.GetRegionByIdAsync(command.Id);
        if (region == null)
            return default;

        region.Name = command.Name;

        return await _regionRepository.UpdateRegionAsync(region);
    }
}
