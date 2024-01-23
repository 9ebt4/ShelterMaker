using System;
using System.Collections.Generic;

namespace ShelterDB.Models;

public partial class Associate
{
    public int AssociateId { get; set; }

    public bool? IsActive { get; set; }

    public int? FacilityId { get; set; }

    public int? AssociateMaintenanceId { get; set; }

    public virtual ICollection<Alteration> Alterations { get; set; } = new List<Alteration>();

    public virtual AssociateMaintenance? AssociateMaintenance { get; set; }

    public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; } = new List<EmergencyContact>();

    public virtual Facility? Facility { get; set; }

    public virtual ICollection<GoogleUser> GoogleUsers { get; set; } = new List<GoogleUser>();

    public virtual ICollection<Incident> Incidents { get; set; } = new List<Incident>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();
}
