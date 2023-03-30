using Address.Commands.Cities;
using Address.Repositories.Cities;
using MediatR;

namespace Address.Handlers.Cities;

public class DeleteCityHandler : IRequestHandler<DeleteCityCommand, int>
{
    private readonly ICityRepository _cityRepository;

    public DeleteCityHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public async Task<int> Handle(DeleteCityCommand command, CancellationToken cancellationToken)
    {
        var city = await _cityRepository.GetCityByIdAsync(command.Id);
        if (city == null)
            return default;

        return await _cityRepository.DeleteCityAsync(command.Id);
    }
}
