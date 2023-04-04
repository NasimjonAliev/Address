using Address.Entities;
using AutoMapper;

namespace Address.Commands.Streets;

public class UpdateStreetMapper : Profile
{
    public UpdateStreetMapper()
    {
        CreateMap<UpdateStreetCommand, Street>();
    }
}
