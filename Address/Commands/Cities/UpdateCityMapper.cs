using Address.Entities;
using AutoMapper;

namespace Address.Commands.Cities;

public class UpdateCityMapper : Profile
{
    UpdateCityMapper()
    {
        CreateMap<City, UpdateCityCommand>();
    }
}
