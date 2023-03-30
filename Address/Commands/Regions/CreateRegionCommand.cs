using Address.Entities;
using MediatR;

namespace Address.Commands.Regions;

public class CreateRegionCommand : IRequest<Region>
{
    public string Name { get; set; }

    public CreateRegionCommand(string regionName)
    {
        Name = regionName;
    }
}