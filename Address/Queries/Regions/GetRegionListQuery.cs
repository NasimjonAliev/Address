using Address.Entities;
using MediatR;

namespace Address.Queries.Regions;

public class GetRegionListQuery : IRequest<List<Region>>
{
}

