using Address.Entities;
using AutoMapper;

namespace Address.Commands.Countries;

public class CreateCountryMapper : Profile
{
    public CreateCountryMapper()
    {
        CreateMap<CreateCountryCommand, Country> ();
    }
}
