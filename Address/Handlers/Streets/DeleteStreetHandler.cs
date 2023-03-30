using Address.Commands.Streets;
using Address.Repositories.Streets;
using MediatR;

namespace Address.Handlers.Streets;

public class DeleteStreetHandler : IRequestHandler<DeleteStreetCommand, int>
{
    private readonly IStreetRepository _streetRepository;

    public DeleteStreetHandler(IStreetRepository streetRepository)
    {
        _streetRepository = streetRepository;
    }

    public async Task<int> Handle(DeleteStreetCommand command, CancellationToken cancellationToken)
    {
        var street = await _streetRepository.GetStreetByIdAsync(command.Id);
        if (street == null)
            return default;

        return await _streetRepository.DeleteStreetAsync(command.Id);
    }
}
