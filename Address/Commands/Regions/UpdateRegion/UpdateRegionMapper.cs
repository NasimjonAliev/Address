using Address.Entities;
using AutoMapper;

namespace Address.Commands.Regions;

public class UpdateRegionMapper : Profile
{
    public UpdateRegionMapper()
    {
        CreateMap<UpdateRegionMapper, Region>();
    }
}
