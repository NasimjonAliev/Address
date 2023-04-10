using MediatR;

namespace Address.Queries.Countries;

public class GetCountryByIdQuery : IRequest<GetCountryByIdViewModel>
{
    public int Id { get; set; }
}


