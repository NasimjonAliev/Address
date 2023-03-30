using Address.Models;
using Address.Queries.Countries;
using Address.Repositories.Countries;
using MediatR;

namespace Address.Handlers.Countries;

public class GetCountryListHandler : IRequestHandler<GetCountryListQuery, List<Country>>
{
    private readonly ICountryRepository _countryRepository;

    public GetCountryListHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async Task<List<Country>> Handle(GetCountryListQuery query, CancellationToken cancellationToken)
    {
        return await _countryRepository.GetCountryListAsync();
    }
}