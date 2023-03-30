using Address.Commands.Regions;
using Address.Entities;
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
    public async Task<List<Region>> GetRegionListAsync()
    {
        var region = await mediator.Send(new GetRegionListQuery());

        return region;
    }

    [HttpGet("regionId")]
    public async Task<Region> GetRegionByIdAsync(int regionId)
    {
        var region = await mediator.Send(new GetRegionByIdQuery() { Id = regionId });

        return region;
    }

    [HttpPost]
    public async Task<Region> AddRegionAsync(Region region)
    {
        var regionAdd = await mediator.Send(new CreateRegionCommand(
            region.Name));

        return regionAdd;
    }

    [HttpPut]
    public async Task<int> UpdateRegionAsync(Region region)
    {
        var regionUpdate = await mediator.Send(new UpdateRegionCommand(
            region.Id,
            region.Name));

        return regionUpdate;
    }

    [HttpDelete]
    public async Task<int> DeleteRegionAsync(int Id)
    {
        return await mediator.Send(new DeleteRegionCommand() { Id = Id });
    }
}
