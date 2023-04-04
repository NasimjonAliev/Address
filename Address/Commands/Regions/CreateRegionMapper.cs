using Address.Entities;
using AutoMapper;

namespace Address.Commands.Regions;

public class CreateRegionMapper : Profile
{
    public CreateRegionMapper()
    {
        CreateMap<CreateRegionCommand, Region>();
    }
}
