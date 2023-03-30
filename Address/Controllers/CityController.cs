using Address.Commands.Cities;
using Address.Entities;
using Address.Queries.Cities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Address.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CityController : Controller
{
    private readonly IMediator mediator;

    public CityController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<List<City>> GetCityListAsync()
    {
        var city = await mediator.Send(new GetCityListQuery());

        return city;
    }

    [HttpGet("cityId")]
    public async Task<City> GetCityByIdAsync(int cityId)
    {
        var city = await mediator.Send(new GetCityByIdQuery() { Id = cityId });

        return city;
    }

    [HttpPost]
    public async Task<City> AddCityAsync(City city)
    {
        var cityAdd = await mediator.Send(new CreateCityCommand(
            city.Name,
            city.PostIndex,
            city.DistrictName));

        return cityAdd;
    }

    [HttpPut]
    public async Task<int> UpdateCityAsync(City city)
    {
        var cityUpdate = await mediator.Send(new UpdateCityCommand(
            city.Id,
            city.Name,
            city.PostIndex,
            city.DistrictName));

        return cityUpdate;
    }

    [HttpDelete]
    public async Task<int> DeleteCityAsync(int Id)
    {
        return await mediator.Send(new DeleteCityCommand() { Id = Id });
    }
}
