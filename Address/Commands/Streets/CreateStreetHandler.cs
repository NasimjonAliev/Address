using Address.Commands.Streets;
using Address.Entities;
using Address.Repositories.Streets;
using MediatR;

namespace Address.Handlers.Streets;

public class CreateStreetHandler : IRequestHandler<CreateStreetCommand, Street>
{
    private readonly IStreetRepository _streetRepository;

    public CreateStreetHandler(IStreetRepository streetRepository)
    {
        _streetRepository = streetRepository;
    }

    public async Task<Street> Handle(CreateStreetCommand command, CancellationToken cancellationToken)
    {
        var street = new Street()
        {
            Name = command.Name,
            Number = command.Number
        };

        return await _streetRepository.AddStreetAsync(street);
    }
}