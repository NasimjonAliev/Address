using Address.Models;
using AutoMapper;

namespace Address.Commands.Countries;

public class UpdateCountryMapper : Profile
{
    public UpdateCountryMapper()
    {
        CreateMap<Country, CreateCountryCommand > ();
    }
}
