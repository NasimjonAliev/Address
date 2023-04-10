using MediatR;

namespace Address.Queries.Streets;

public class GetStreetByIdQuery : IRequest<GetStreetByIdViewModel>
{
    public int Id { get; set; }
}
