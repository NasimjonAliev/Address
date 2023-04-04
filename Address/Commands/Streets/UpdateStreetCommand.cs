using Address.Context;
using AutoMapper;
using MediatR;

namespace Address.Commands.Streets;

public class UpdateStreetCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }
}

public class UpdateStreetHandler : IRequestHandler<UpdateStreetCommand, int>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateStreetHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(UpdateStreetCommand command, CancellationToken cancellationToken)
    {
        var street = _context.Streets.Where(a => a.Id == command.Id).FirstOrDefault();

        if (street == null)
            return default;

        _mapper.Map(command, street);

        await _context.SaveChangesAsync();

        return street.Id;
    }
}
