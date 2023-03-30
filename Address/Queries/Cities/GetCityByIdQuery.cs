using Address.Entities;
using MediatR;

namespace Address.Queries.Cities;

public class GetCityByIdQuery : IRequest<City>
{
    public int Id { get; set; }
}
