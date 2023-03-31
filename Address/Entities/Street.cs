﻿using Address.Entities.Common;

namespace Address.Entities;

public class Street : BaseEntity
{
    public string Number { get; set; }


    public int CityId { get; set; }
    public City City { get; set; } 
}
