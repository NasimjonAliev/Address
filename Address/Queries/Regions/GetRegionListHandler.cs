using Address.Entities;
using Address.Queries.Regions;
using Address.Repositories.Regions;
using MediatR;

namespace Address.Handlers.Regions;

public class GetRegionListHandler : IRequestHandler<GetRegionListQuery, List<Region>>
{
    private readonly IRegionRepository _regionRepository;

    public GetRegionListHandler(IRegionRepository regionRepository)
    {
        _regionRepository = regionRepository;
    }

    public async Task<List<Region>> Handle(GetRegionListQuery query, CancellationToken cancellationToken)
    {
        return await _regionRepository.GetRegionListAsync();
    }
}