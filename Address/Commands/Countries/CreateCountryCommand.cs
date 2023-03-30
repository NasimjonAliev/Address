using Address.Models;
using MediatR;

namespace Address.Commands.Countries;

public class CreateCountryCommand : IRequest<Country>
{
    public string Name { get; set; }
    public string Code { get; set; }

    public CreateCountryCommand(string countryName, string countryCode)
    {
        Name = countryName;
        Code = countryCode;
    }
}

