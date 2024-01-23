using System;
using System.Collections.Generic;

namespace ShelterDB.Models;

public partial class Checklist
{
    public int ChecklistId { get; set; }

    public int? FacilityId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public virtual ICollection<ChecklistMaintenance> ChecklistMaintenances { get; set; } = new List<ChecklistMaintenance>();

    public virtual Facility? Facility { get; set; }
}
