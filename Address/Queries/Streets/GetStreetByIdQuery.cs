using Address.Entities;
using MediatR;

namespace Address.Queries.Streets;

public class GetStreetByIdQuery : IRequest<Street>
{
    public int Id { get; set; }
}