using Address.Commands.Countries;
using Address.Models;
using Address.Queries.Countries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Address.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountryController : Controller
{
    private readonly IMediator mediator;

    public CountryController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<List<Country>> GetCountryListAsync()
    {
        var country = await mediator.Send(new GetCountryListQuery());

        return country;
    }

    [HttpGet("countryId")]
    public async Task<Country> GetCountyByIdAsync(int countryId)
    {
        var country = await mediator.Send(new GetCountryByIdQuery() { Id = countryId });

        return country;
    }

    [HttpPost]
    public async Task<Country> AddCountryAsync(Country country)
    {
        var countryAdd = await mediator.Send(new CreateCountryCommand(
            country.Name,
            country.Code));

        return countryAdd;
    }

    [HttpPut]
    public async Task<int> UpdateCountryAsync(Country country)
    {
        var countryUpdate = await mediator.Send(new UpdateCountryCommand(
            country.Id,
            country.Name,
            country.Code));

        return countryUpdate;
    }

    [HttpDelete]
    public async Task<int> DeleteCountryAsync(int Id)
    {
        return await mediator.Send(new DeleteCountryCommand() { Id = Id });
    }
}
