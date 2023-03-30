using Address.Commands.Cities;
using Address.Repositories.Cities;
using MediatR;

namespace Address.Handlers.Cities;

public class UpdateCityHandler : IRequestHandler<UpdateCityCommand, int>
{
    private readonly ICityRepository _cityRepository;

    public UpdateCityHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public async Task<int> Handle(UpdateCityCommand command, CancellationToken cancellationToken)
    {
        var city = await _cityRepository.GetCityByIdAsync(command.Id);
        if (city == null)
            return default;

        city.Name = command.Name;
        city.PostIndex = command.PostIndex;
        city.DistrictName = command.DistrictName;

        return await _cityRepository.UpdateCityAsync(city);
    }
}
