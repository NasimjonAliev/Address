using Address.Entities;
using Address.Queries.Regions;
using Address.Repositories.Regions;
using MediatR;

namespace Address.Handlers.Regions;

public class GetRegionByIdHandler : IRequestHandler<GetRegionByIdQuery, Region>
{
    private readonly IRegionRepository _regionRepository;

    public GetRegionByIdHandler(IRegionRepository regionRepository)
    {
        _regionRepository = regionRepository;
    }

    public async Task<Region> Handle(GetRegionByIdQuery query, CancellationToken cancellationToken)
    {
        return await _regionRepository.GetRegionByIdAsync(query.Id);
    }
}
