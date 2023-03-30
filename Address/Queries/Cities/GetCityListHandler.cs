using Address.Entities;
using Address.Queries.Cities;
using Address.Repositories.Cities;
using MediatR;

namespace Address.Handlers.Cities;

public class GetCityListHandler : IRequestHandler<GetCityListQuery, List<City>>
{
    private readonly ICityRepository _cityRepository;

    public GetCityListHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public async Task<List<City>> Handle(GetCityListQuery query, CancellationToken cancellationToken)
    {
        return await _cityRepository.GetCityListAsync();
    }
}