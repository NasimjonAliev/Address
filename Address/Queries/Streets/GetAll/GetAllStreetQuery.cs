using MediatR;

namespace Address.Queries.Streets;

public class GetAllStreetQuery : IRequest<IEnumerable<GetAllStreetViewModel>>
{
}

