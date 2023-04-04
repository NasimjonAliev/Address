using Address.Context;
using AutoMapper;
using MediatR;

namespace Address.Commands.Countries;

public class UpdateCountryCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Area { get; set; }
    public string Population { get; set; }
    public string Mainland { get; set; }
    public string Type { get; set; }
}
public class UpdateCountryHandler : IRequestHandler<UpdateCountryCommand, int>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateCountryHandler(ApplicationDbContext context, IMapper mapper)
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
