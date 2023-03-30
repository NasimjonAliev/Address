using Address.Models;
using AutoMapper;

namespace Address.Commands.Countries;

public class CreateCountryMapper : Profile
{
    public CreateCountryMapper()
    {
        CreateMap<CreateCountryCommand, Country>();
    }
}
