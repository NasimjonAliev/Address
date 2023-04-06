using MediatR;

namespace Address.Queries.Cities;

public class GetCityByIdQuery : IRequest<GetCityByIdViewModel>
{
    public int Id { get; set; }
}

