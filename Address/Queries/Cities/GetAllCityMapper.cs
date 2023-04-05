using Address.Entities;
using AutoMapper;

namespace Address.Queries.Cities;

public class GetAllCityMapper : Profile
{
    public GetAllCityMapper()
    {
        CreateMap<City, GetAllCityViewModel>();
    }
}
