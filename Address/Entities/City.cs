using Address.Entities.Common;

namespace Address.Entities;

public class City : BaseEntity
{
    public uint PostIndex { get; set; }


    public int RegionId { get; set; }
    public Region Region { get; set; }

    public ICollection<Street> Streets { get; set; }
}
