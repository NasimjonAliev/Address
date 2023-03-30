using Address.Models;
using MediatR;

namespace Address.Queries.Countries;

public class GetCountryListQuery : IRequest<List<Country>>
{
}
