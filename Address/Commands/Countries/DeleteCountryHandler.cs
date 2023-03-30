using Address.Commands.Countries;
using Address.Repositories.Countries;
using MediatR;

namespace Address.Handlers.Countries;

public class DeleteCountryHandler : IRequestHandler<DeleteCountryCommand, int>
{
    private readonly ICountryRepository _countryRepository;

    public DeleteCountryHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<int> Handle(DeleteCountryCommand command, CancellationToken cancellationToken)
    {
        var country = await _countryRepository.GetCountryByIdAsync(command.Id);
        if (country == null)
            return default;

        return await _countryRepository.DeleteCountryAsync(command.Id);
    }
}
