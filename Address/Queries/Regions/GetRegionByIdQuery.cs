using Address.Entities;
using MediatR;

namespace Address.Queries.Regions;

public class GetRegionByIdQuery : IRequest<Region>
{
    public int Id { get; set; }
}