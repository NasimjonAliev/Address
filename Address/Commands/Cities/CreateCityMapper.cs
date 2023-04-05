using Address.Entities;
using AutoMapper;

namespace Address.Commands.Cities;

public class CreateCityMapper : Profile
{
    public CreateCityMapper()
    {
        CreateMap<CreateCityCommand, City>();
    }
}
