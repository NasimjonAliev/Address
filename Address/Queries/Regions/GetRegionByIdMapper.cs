using Address.Entities;
using AutoMapper;

namespace Address.Queries.Regions;

public class GetRegionByIdMapper : Profile
{
    public GetRegionByIdMapper()
    {
        CreateMap<Region, GetRegionByIdViewModel>();
    }
}
