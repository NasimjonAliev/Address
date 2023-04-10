using MediatR;

namespace Address.Commands.Regions;

public class CreateRegionCommand : IRequest<int>
{
    public string Name { get; set; }
    public string DistrictName { get; set; }
    public int CountyId { get; set; }
}
