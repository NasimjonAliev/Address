using MediatR;

namespace Address.Commands.Streets;

public class UpdateStreetCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }

    public UpdateStreetCommand(int streetId, string streetName, string streetNumber)
    {
        Id = streetId;
        Name = streetName;
        Number = streetNumber;
    }
}
