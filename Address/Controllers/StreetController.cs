using Address.Commands.Streets;
using Address.Entities;
using Address.Queries.Streets;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Address.Controllers;

[Route("api/[controller]")]
[ApiController]

public class StreetController : Controller
{
    private readonly IMediator mediator;

    public StreetController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<List<Street>> GetStreetListAsync()
    {
        var street = await mediator.Send(new GetStreetListQuery());

        return street;
    }

    [HttpGet("streetId")]
    public async Task<Street> GetStreetByIdAsync(int streetId)
    {
        var street = await mediator.Send(new GetStreetByIdQuery() { Id = streetId });

        return street;
    }

    [HttpPost]
    public async Task<Street> AddStreetAsync(Street street)
    {
        var streetAdd = await mediator.Send(new CreateStreetCommand(
            street.Name,
            street.Number));

        return streetAdd;
    }

    [HttpPut]
    public async Task<int> UpdateStreetAsync(Street street)
    {
        var streetUpdate = await mediator.Send(new UpdateStreetCommand(
            street.Id,
            street.Name,
            street.Number));

        return streetUpdate;
    }

    [HttpDelete]
    public async Task<int> DeleteStreetAsync(int Id)
    {
        return await mediator.Send(new DeleteStreetCommand() { Id = Id });
    }
}
