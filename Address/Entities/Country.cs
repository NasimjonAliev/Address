using Address.Entities;
using Address.Entities.Common;

namespace Address.Models;

public class Country : BaseEntity
{
    public string Code { get; set; }

    public ICollection<Region> Regions { get; set; }
}
