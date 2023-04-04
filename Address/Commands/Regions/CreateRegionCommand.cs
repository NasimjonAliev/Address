using Address.Context;
using Address.Entities;
using AutoMapper;
using MediatR;

namespace Address.Commands.Regions;

public class CreateRegionCommand : IRequest<int>
{
    public string Name { get; set; }
    public string DistrictName { get; set; }
    public int CountyId { get; set; }
}

public class CreateRegionHandler : IRequestHandler<CreateRegionCommand, int>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateRegionHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateRegionCommand command, CancellationToken cancellationToken)
    {
        var region = _mapper.Map<Region>(command);

        _context.Regions.Add(region);
        await _context.SaveChangesAsync();
        return region.Id;
    }
}