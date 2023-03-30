using Address.Entities;
using MediatR;

namespace Address.Queries.Cities;

public class GetCityListQuery : IRequest<List<City>>
{
}
