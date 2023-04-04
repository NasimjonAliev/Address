using Address.Entities;
using AutoMapper;

namespace Address.Commands.Cities;

public class CreateCityMapper : Profile
{
    CreateCityMapper()
    {
        CreateMap<CreateCityCommand, City >();
    }
}
