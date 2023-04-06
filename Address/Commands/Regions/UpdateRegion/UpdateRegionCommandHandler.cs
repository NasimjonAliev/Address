using Address.Context;
using AutoMapper;
using MediatR;

namespace Address.Commands.Regions.UpdateRegion;

public class UpdateRegionCommandHandler : IRequestHandler<UpdateRegionCommand, int>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateRegionCommandHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(UpdateRegionCommand command, CancellationToken cancellationToken)
    {
        var region = _context.Regions.Where(a => a.Id == command.Id).FirstOrDefault();

        if (region == null)
            return default;

        _mapper.Map(command, region);

        await _context.SaveChangesAsync();

        return region.Id;
    }
}