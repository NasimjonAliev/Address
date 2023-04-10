using MediatR;

namespace Address.Commands.Streets;

public class CreateStreetCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Number { get; set; }
    public int CityId { get; set; }
}



