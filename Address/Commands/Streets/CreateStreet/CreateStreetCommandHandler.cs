using Address.Context;
using Address.Entities;
using AutoMapper;
using MediatR;

namespace Address.Commands.Streets.CreateStreet;

public class CreateStreetCommandHandler : IRequestHandler<CreateStreetCommand, int>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateStreetCommandHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateStreetCommand command, CancellationToken cancellationToken)
    {
        var street = _mapper.Map<Street>(command);

        _context.Streets.Add(street);

        await _context.SaveChangesAsync();

        return street.Id;
    }
}
