using MediatR;

namespace Address.Commands.Cities;

public class DeleteCityCommand : IRequest<int>
{
    public int Id { get; set; }
}


