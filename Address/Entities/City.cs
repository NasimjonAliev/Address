using Address.Entities.Common;
using System.Text.Json.Serialization;

namespace Address.Entities;

public class City : BaseEntity
{
    public uint PostIndex { get; set; }
    public string DistrictName { get; set; }

    public int RegionId { get; set; }
    public Region Region { get; set; }

    public ICollection<Street> Streets { get; set; }
}
