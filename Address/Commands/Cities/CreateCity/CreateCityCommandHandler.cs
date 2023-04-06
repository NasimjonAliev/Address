using Address.Context;
using Address.Entities;
using AutoMapper;
using MediatR;

namespace Address.Commands.Cities.CreateCity;

public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, int>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateCityCommandHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateCityCommand command, CancellationToken cancellationToken)
    {
        var city = _mapper.Map<City>(command);

        _context.Cities.Add(city);

        await _context.SaveChangesAsync();

        return city.Id;
    }
}
