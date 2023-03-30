using Address.Commands.Streets;
using Address.Repositories.Streets;
using MediatR;

namespace Address.Handlers.Streets;

public class UpdateStreetHandler : IRequestHandler<UpdateStreetCommand, int>
{
    private readonly IStreetRepository _streetRepository;

    public UpdateStreetHandler(IStreetRepository streetRepository)
    {
        _streetRepository = streetRepository;
    }

    public async Task<int> Handle(UpdateStreetCommand command, CancellationToken cancellationToken)
    {
        var street = await _streetRepository.GetStreetByIdAsync(command.Id);
        if (street == null)
            return default;

        street.Name = command.Name;
        street.Number = command.Number;

        return await _streetRepository.UpdateStreetAsync(street);
    }
}