using Address.Commands.Countries;
using Address.Models;
using Address.Repositories.Countries;
using MediatR;

namespace Address.Handlers.Countries;

public class CreateCountryHandler : IRequestHandler<CreateCountryCommand, Country>
{
    private readonly ICountryRepository _countryRepository;

    public CreateCountryHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<Country> Handle(CreateCountryCommand command, CancellationToken cancellationToken)
    {
        var country = new Country()
        {
            Name = command.Name,
            Code = command.Code
        };

        return await _countryRepository.AddCountryAsync(country);
    }
}