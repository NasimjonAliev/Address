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
