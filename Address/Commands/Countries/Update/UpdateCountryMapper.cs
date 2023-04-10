using Address.Entities;
using AutoMapper;

namespace Address.Commands.Countries;

public class UpdateCountryMapper : Profile
{
    public UpdateCountryMapper()
    {
        CreateMap<UpdateCountryCommand, Country> ();
    }
}
