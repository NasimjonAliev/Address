using Address.Commands.Regions;
using Address.Queries.Regions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Address.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]

public class RegionController : Controller
{
    private readonly IMediator _mediator;

    public RegionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRegion()
    {
        return Ok(await _mediator.Send(new GetAllRegionQuery()));
    }

    [HttpGet("Id")]
    public async Task<IActionResult> GetRegionById(int id)
    {
        return Ok(await _mediator.Send(new GetRegionByIdQuery{ Id = id }));
    }

    [HttpPost]
    public async Task<IActionResult> AddRegion(CreateRegionCommand region)
    {
        return Ok(await _mediator.Send(region));
    }

    [HttpPut("Id")]
    public async Task<IActionResult> UpdateRegion(int id, UpdateRegionCommand command)
    {
        command.Id = id;

        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("Id")]
    public async Task<IActionResult> DeleteRegion(int id)
    {
        return Ok(await _mediator.Send(new DeleteRegionCommand { Id = id }));
    }
}



