using Address.Context;
using Address.Entities;
using AutoMapper;
using MediatR;

namespace Address.Commands.Countries.CreateCountry;

public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand, int>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateCountryCommandHandler(ApplicationDbContext context, IMapper mapper)
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