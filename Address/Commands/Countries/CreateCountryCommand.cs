using Address.Context;
using Address.Entities;
using AutoMapper;
using MediatR;

namespace Address.Commands.Countries;

public class CreateCountryCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string Area { get; set; }
    public string Population { get; set; }
    public string Mainland { get; set; }
    public string Type { get; set; } 
}

public class CreateCountryHandler : IRequestHandler<CreateCountryCommand, int>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateCountryHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateCountryCommand command, CancellationToken cancellationToken)
    {
        var country = _mapper.Map<Country>(command);

        _context.Countries.Add(country);
        await _context.SaveChangesAsync();
        return country.Id;
    }
}

