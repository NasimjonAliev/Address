using Address.Commands.Cities;
using Address.Entities;
using Address.Repositories.Cities;
using MediatR;

namespace Address.Handlers.Cities;

public class CreateCityHandler : IRequestHandler<CreateCityCommand, City>
{
    private readonly ICityRepository _cityRepository;

    public CreateCityHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public async Task<City> Handle(CreateCityCommand command, CancellationToken cancellationToken)
    {
        var city = new City()
        {
            Name = command.Name,
            PostIndex = command.PostIndex,
            DistrictName = command.DistrictName
        };

        return await _cityRepository.AddCityAsync(city);
    }
}
