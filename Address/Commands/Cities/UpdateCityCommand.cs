using Address.Context;
using AutoMapper;
using MediatR;

namespace Address.Commands.Cities;

public class UpdateCityCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public uint PostIndex { get; set; }
}

public class UpdateCityHandler : IRequestHandler<UpdateCityCommand, int>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateCityHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(UpdateCityCommand command, CancellationToken cancellationToken)
    {
        var city = _context.Cities.Where(a => a.Id == command.Id).FirstOrDefault();
        if (city == null)
            return default;

        _mapper.Map(command, city);

        await _context.SaveChangesAsync();

        return city.Id;
    }
}
