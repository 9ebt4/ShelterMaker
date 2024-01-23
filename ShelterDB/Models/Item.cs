using System;
using System.Collections.Generic;

namespace ShelterDB.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public int? ChecklistMaintenanceId { get; set; }

    public string? Content { get; set; }

    public bool? IsChecked { get; set; }

    public virtual ChecklistMaintenance? ChecklistMaintenance { get; set; }
}
