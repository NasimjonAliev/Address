using MediatR;

namespace Address.Queries.Countries;

public class GetAllCountryQuery : IRequest<IEnumerable<GetAllCountryViewModel>>
{
}
