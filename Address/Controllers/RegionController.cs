using Address.Commands.Regions;
using Address.Queries.Regions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Address.Controllers;

[Route("api/[controller]")]
[ApiController]

public class RegionController : Controller
{
    private readonly IMediator mediator;

    public RegionController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRegion()
    {
        return Ok(await mediator.Send(new GetAllRegionQuery()));
    }

    [HttpGet("Id")]
    public async Task<IActionResult> GetRegionById(int id)
    {
        return Ok(await mediator.Send(new GetRegionByIdQuery{ Id = id }));
    }

    [HttpPost]
    public async Task<IActionResult> AddRegion(CreateRegionCommand region)
    {
        return Ok(await mediator.Send(region));
    }

    [HttpPut("Id")]
    public async Task<IActionResult> UpdateRegion(int id, UpdateRegionCommand command)
    {
        command.Id = id;

        return Ok(await mediator.Send(command));
    }

    [HttpDelete("Id")]
    public async Task<IActionResult> DeleteRegion(int id)
    {
        return Ok(await mediator.Send(new DeleteRegionCommand { Id = id }));
    }
}



