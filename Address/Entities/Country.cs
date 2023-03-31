using Address.Entities;
using Address.Entities.Common;

namespace Address.Models;

public class Country : BaseEntity
{
    public string Code { get; set; }
    public string Area { get; set; }
    public string Population { get; set; }
    public string Mainland { get; set; }
    public string Type { get; set; }

    public ICollection<Region> Regions { get; set; }
}
