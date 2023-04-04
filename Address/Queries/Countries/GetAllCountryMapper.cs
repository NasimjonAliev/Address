using Address.Entities;
using AutoMapper;

namespace Address.Queries.Countries;

public class GetAllCountryMapper : Profile
{
    public GetAllCountryMapper()
    {
        CreateMap<Country, GetAllCountryViewModel>();
    }
}
