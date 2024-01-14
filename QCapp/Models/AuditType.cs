using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class AuditType
{
    public int AuditTypeId { get; set; }

    public string? AuditTypeName { get; set; }

    public virtual ICollection<Audit> Audits { get; set; } = new List<Audit>();
}
