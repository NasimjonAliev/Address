using Address.Models;
using Address.Queries.Countries;
using Address.Repositories.Countries;
using MediatR;

namespace Address.Handlers.Countries;

public class GetCountryByIdHandler : IRequestHandler<GetCountryByIdQuery, Country>
{
    private readonly ICountryRepository _countryRepository;

    public GetCountryByIdHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<Country> Handle(GetCountryByIdQuery query, CancellationToken cancellationToken)
    {
        return await _countryRepository.GetCountryByIdAsync(query.Id);
    }
}