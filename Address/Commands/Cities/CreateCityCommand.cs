using Address.Entities;
using MediatR;

namespace Address.Commands.Cities;

public class CreateCityCommand : IRequest<City>
{
    public string Name { get; set; }
    public uint PostIndex { get; set; }
    public string DistrictName { get; set; }

    public CreateCityCommand(string cityName, uint cityPostIndex, string districtName)
    {
        Name = cityName;
        PostIndex = cityPostIndex;
        DistrictName = districtName;
    }
}
