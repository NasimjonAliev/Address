using MediatR;

namespace Address.Commands.Cities;

public class CreateCityCommand : IRequest<int>
{
    public string Name { get; set; }
    public uint PostIndex { get; set; }
    public int RegionId { get; set; }
}

