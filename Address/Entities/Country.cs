using Address.Entities.Common;

namespace Address.Entities;

public class Country : BaseEntity
{
    public string Code { get; set; }
    public string Area { get; set; }
    public string Population { get; set; }
    public string Mainland { get; set; }
    public string Type { get; set; }

    public ICollection<Region> Regions { get; set; }
}
