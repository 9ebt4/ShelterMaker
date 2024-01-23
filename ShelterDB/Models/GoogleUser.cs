using System;
using System.Collections.Generic;

namespace ShelterDB.Models;

public partial class GoogleUser
{
    public int GoogleUserId { get; set; }

    public string? GoogleToken { get; set; }

    public int? AssociateId { get; set; }

    public int? PersonId { get; set; }

    public bool? IsActive { get; set; }

    public virtual Associate? Associate { get; set; }

    public virtual Person? Person { get; set; }
}
