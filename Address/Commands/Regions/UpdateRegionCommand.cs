using MediatR;

namespace Address.Commands.Regions;

public class UpdateRegionCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public UpdateRegionCommand(int regionId, string regionName)
    {
        Id = regionId;
        Name = regionName;
    }
}
