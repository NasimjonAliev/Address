using Address.Entities;
using AutoMapper;

namespace Address.Queries.Regions;

public class GetAllRegionMapper : Profile
{
    public GetAllRegionMapper()
    {
        CreateMap<Region, GetAllRegionViewModel>();
    }
}
