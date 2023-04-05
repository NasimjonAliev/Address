using Address.Entities;
using AutoMapper;

namespace Address.Queries.Streets;

public class GetStreetByIdMapper : Profile
{
    public GetStreetByIdMapper()
    {
        CreateMap<Street, GetStreetByIdViewModel>();
    }
}
