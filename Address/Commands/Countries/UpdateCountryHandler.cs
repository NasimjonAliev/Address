using Address.Commands.Countries;
using Address.Repositories.Countries;
using MediatR;

namespace Address.Handlers.Countries;

public class UpdateCountryHandler : IRequestHandler<UpdateCountryCommand, int>
{
    private readonly ICountryRepository _countryRepository;

    public UpdateCountryHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<int> Handle(UpdateCountryCommand command, CancellationToken cancellationToken)
    {
        var country = await _countryRepository.GetCountryByIdAsync(command.Id);
        if (country == null)
            return default;

        country.Name = command.Name;
        country.Code = command.Code;

        return await _countryRepository.UpdateCountryAsync(country);
    }
}
