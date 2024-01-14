using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class Process
{
    public int ProcessId { get; set; }

    public string? ProcessCode { get; set; }

    public string? ProcessName { get; set; }

    public virtual ICollection<Billing> Billings { get; set; } = new List<Billing>();

    public virtual ICollection<LoansFile> LoansFiles { get; set; } = new List<LoansFile>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
