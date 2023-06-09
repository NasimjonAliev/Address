﻿using Address.Commands.Cities;
using Address.Queries.Cities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Address.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class CityController : Controller
{
    private readonly IMediator _mediator;

    public CityController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCity()
    {
        return Ok(await _mediator.Send(new GetAllCityQuery()));
    }

    [HttpGet("Id")]
    public async Task<IActionResult> GetCityById(int id)
    {
        return Ok(await _mediator.Send(new GetCityByIdQuery { Id = id }));
    }

    [HttpPost]
    public async Task<IActionResult> CreateCity(CreateCityCommand city)
    {
        return Ok(await _mediator.Send(city));
    }

    [HttpPut("Id")]
    public async Task<IActionResult> UpdateCity(int id, UpdateCityCommand command)
    {
        command.Id = id;
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("Id")]
    public async Task<IActionResult> DeleteCity(int id)
    {
        return Ok(await _mediator.Send(new DeleteCityCommand { Id = id }));
    }
}
