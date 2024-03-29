﻿using System;
using System.Collections.Generic;

namespace ShelterDB.Models;

public partial class Facility
{
    public int FacilityId { get; set; }

    public string? Name { get; set; }

    public string? FacilityCode { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Associate> Associates { get; set; } = new List<Associate>();

    public virtual ICollection<Bed> Beds { get; set; } = new List<Bed>();

    public virtual ICollection<Checklist> Checklists { get; set; } = new List<Checklist>();

    public virtual ICollection<ContactInfo> ContactInfos { get; set; } = new List<ContactInfo>();

    public virtual ICollection<Patron> Patrons { get; set; } = new List<Patron>();
}
