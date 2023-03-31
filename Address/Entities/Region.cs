﻿using Address.Entities.Common;
using Address.Models;

namespace Address.Entities;

public class Region : BaseEntity
{
    public string DistrictName { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }

    public ICollection<City> Cities { get; set; }
}
