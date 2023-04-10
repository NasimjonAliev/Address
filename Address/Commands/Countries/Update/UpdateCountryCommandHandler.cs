using Address.Context;
using AutoMapper;
using MediatR;

namespace Address.Commands.Countries.UpdateCountry;

public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommand, int>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateCountryCommandHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(UpdateCountryCommand command, CancellationToken cancellationToken)
    {
        var country = _context.Countries.Where(a => a.Id == command.Id).FirstOrDefault();

        if (country == null)
            return default;

        _mapper.Map(command, country);

        await _context.SaveChangesAsync();

        return country.Id;
    }
}
