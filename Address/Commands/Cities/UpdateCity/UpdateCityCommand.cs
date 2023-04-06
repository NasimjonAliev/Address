using MediatR;

namespace Address.Commands.Cities;

public class UpdateCityCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public uint PostIndex { get; set; }
}


