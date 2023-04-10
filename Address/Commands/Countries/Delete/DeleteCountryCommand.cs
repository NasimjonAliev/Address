using MediatR;

namespace Address.Commands.Countries;

public class DeleteCountryCommand : IRequest<int>
{
    public int Id { get; set; }
}


