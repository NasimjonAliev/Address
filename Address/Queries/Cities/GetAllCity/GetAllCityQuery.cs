using MediatR;

namespace Address.Queries.Cities;

public class GetAllCityQuery : IRequest<IEnumerable<GetAllCityViewModel>>
{
}

