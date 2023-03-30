using Address.Entities;
using MediatR;

namespace Address.Queries.Streets;

public class GetStreetListQuery : IRequest<List<Street>>
{
}

