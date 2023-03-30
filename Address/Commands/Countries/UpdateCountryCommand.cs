using MediatR;

namespace Address.Commands.Countries;

public class UpdateCountryCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }

    public UpdateCountryCommand(int countryId, string countryName, string countryCode)
    {
        Id = countryId;
        Name = countryName;
        Code = countryCode;
    }
}
