using MediatR;

namespace Address.Commands.Streets;

public class DeleteStreetCommand : IRequest<int>
{
    public int Id { get; set; }
}

