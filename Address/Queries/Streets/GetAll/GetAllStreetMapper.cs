using Address.Entities;
using AutoMapper;

namespace Address.Queries.Streets;

public class GetAllStreetMapper : Profile
{
    public GetAllStreetMapper()
    {
        CreateMap<Street, GetAllStreetViewModel>();
    }
}
