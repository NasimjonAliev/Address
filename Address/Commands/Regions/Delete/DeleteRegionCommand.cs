using MediatR;

namespace Address.Commands.Regions;

public class DeleteRegionCommand : IRequest<int>
{
    public int Id { get; set; }
}



