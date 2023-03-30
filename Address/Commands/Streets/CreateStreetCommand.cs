using Address.Entities;
using MediatR;

namespace Address.Commands.Streets;

public class CreateStreetCommand : IRequest<Street>
{
    public string Name { get; set; }
    public string Number { get; set; }

    public CreateStreetCommand(string streetName, string streetNumber)
    {
        Name = streetName;
        Number = streetNumber;
    }

    public CreateStreetCommand(string name)
    {
        Name = name;
    }
}
