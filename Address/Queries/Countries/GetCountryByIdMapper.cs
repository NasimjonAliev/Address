using Address.Entities;
using AutoMapper;

namespace Address.Queries.Countries;

public class GetCountryByIdMapper : Profile
{
    public GetCountryByIdMapper()
    {
        CreateMap<Country, GetCountryByIdViewModel>();
    }
}
