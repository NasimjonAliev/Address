using Address.Entities;
using AutoMapper;

namespace Address.Queries.Cities;

public class GetCityByIdMapper : Profile
{
    public GetCityByIdMapper()
    {
        CreateMap<City, GetCityByIdViewModel>();
    }
}
