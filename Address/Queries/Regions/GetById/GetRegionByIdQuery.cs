using MediatR;

namespace Address.Queries.Regions;

public class GetRegionByIdQuery : IRequest<GetRegionByIdViewModel>
{
    public int Id { get; set; }
}
