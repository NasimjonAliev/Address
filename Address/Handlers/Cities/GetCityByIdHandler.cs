using Address.Entities;
using Address.Queries.Cities;
using Address.Repositories.Cities;
using MediatR;

namespace Address.Handlers.Cities;

public class GetCityByIdHandler : IRequestHandler<GetCityByIdQuery, City>
{
    private readonly ICityRepository _cityRepository;

    public GetCityByIdHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public async Task<City> Handle(GetCityByIdQuery query, CancellationToken cancellationToken)
    {
        return await _cityRepository.GetCityByIdAsync(query.Id);
    }
}
