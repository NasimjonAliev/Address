using MediatR;

namespace Address.Commands.Cities;

public class UpdateCityCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public uint PostIndex { get; set; }
    public string DistrictName { get; set; }

    public UpdateCityCommand(int cityId, string cityName, uint cityPostIndex, string districtNme)
    {
        Id = cityId;
        Name = cityName;
        PostIndex = cityPostIndex;
        DistrictName = districtNme;
    }
}
