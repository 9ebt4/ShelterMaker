using System;
using System.Collections.Generic;

namespace ShelterDB.Models;

public partial class BedMaintenance
{
    public int BedMaintenanceId { get; set; }

    public int? BedId { get; set; }

    public string? Category { get; set; }

    public virtual Bed? Bed { get; set; }
}
