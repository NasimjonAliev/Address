using Address.Models;
using MediatR;

namespace Address.Queries.Countries;

public class GetCountryByIdQuery : IRequest<Country>
{
    public int Id { get; set; }
}
