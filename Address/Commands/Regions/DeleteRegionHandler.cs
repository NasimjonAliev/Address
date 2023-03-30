using Address.Commands.Regions;
using Address.Repositories.Regions;
using MediatR;

namespace Address.Handlers.Regions;

public class DeleteRegionHandler : IRequestHandler<DeleteRegionCommand, int>
{
    private readonly IRegionRepository _regionRepository;

    public DeleteRegionHandler(IRegionRepository regionRepository)
    {
        _regionRepository = regionRepository;
    }

    public async Task<int> Handle(DeleteRegionCommand command, CancellationToken cancellationToken)
    {
        var region = await _regionRepository.GetRegionByIdAsync(command.Id);
        if (region == null)
            return default;

        return await _regionRepository.DeleteRegionAsync(command.Id);
    }
}
