using Address.Entities.Common;
using Address.Models;
using System.Text.Json.Serialization;

namespace Address.Entities;

public class Region : BaseEntity
{
    public int CountryId { get; set; }
    public Country Country { get; set; }

    public ICollection<City> Cities { get; set; }
}
