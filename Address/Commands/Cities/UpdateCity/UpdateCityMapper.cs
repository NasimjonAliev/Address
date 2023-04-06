using Address.Entities;
using AutoMapper;

namespace Address.Commands.Cities;

public class UpdateCityMapper : Profile
{
    public UpdateCityMapper()
    {
        CreateMap<UpdateCityCommand, City>();
    }
}
