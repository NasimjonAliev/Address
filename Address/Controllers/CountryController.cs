using Address.Commands.Countries;
using Address.Queries.Countries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Address.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class CountryController : Controller
{
    private readonly IMediator _mediator;


    public CountryController(IMediator mediator)
    {
       _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCountry()
    {
        return Ok(await _mediator.Send(new GetAllCountryQuery()));        
    }

    [HttpGet("Id")]
    public async Task<IActionResult> GetCountyById(int id)
    {
        return Ok(await _mediator.Send(new GetCountryByIdQuery { Id = id }));
    }

    [HttpPost]
    public async Task<IActionResult> AddCountry(CreateCountryCommand country)
    {
        return Ok(await _mediator.Send(country));            
    }

    [HttpPut("Id")]
    public async Task<IActionResult> UpdateCountry(int id, UpdateCountryCommand command)
    {
        command.Id = id;
        return Ok(await _mediator.Send(command));        
    }

    [HttpDelete("Id")]
    public async Task<IActionResult> DeleteCountry(int id)
    {
        return Ok(await _mediator.Send(new DeleteCountryCommand { Id = id }));
    }
}
