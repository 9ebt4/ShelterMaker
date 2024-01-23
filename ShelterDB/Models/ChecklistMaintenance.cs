using System;
using System.Collections.Generic;

namespace ShelterDB.Models;

public partial class ChecklistMaintenance
{
    public int ChecklistMaintenanceId { get; set; }

    public int? ChecklistId { get; set; }

    public string? Options { get; set; }

    public virtual Checklist? Checklist { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
