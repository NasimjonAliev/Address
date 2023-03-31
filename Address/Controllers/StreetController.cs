using Address.Commands.Streets;
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
    public async Task<IActionResult> GetAllStreet()
    {
        return Ok(await mediator.Send(new GetAllStreetQuery()));
    }

    [HttpGet("Id")]
    public async Task<IActionResult> GetStreetById(int id)
    {
        return Ok(await mediator.Send(new GetStreetByIdQuery { Id = id }));
    }

    [HttpPost]
    public async Task<IActionResult> CreateStreetCommand(CreateStreetCommand street)
    {
        return Ok(await mediator.Send(street));
    }

    [HttpPut("Id")]
    public async Task<IActionResult> UpdateStreetCommand(int id, UpdateStreetCommand command)
    {
        command.Id = id;
        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Id")]
    public async Task<IActionResult> DeleteStreetCommand(int id)
    {
        return Ok(await mediator.Send(new DeleteStreetCommand { Id = id }));
    }
}
