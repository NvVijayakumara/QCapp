using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class Milestone
{
    public int Id { get; set; }

    public string? Value { get; set; }

    public virtual ICollection<Loan> LoanCurrentMilestoneNavigations { get; set; } = new List<Loan>();

    public virtual ICollection<Loan> LoanLastFinishedMilestoneNavigations { get; set; } = new List<Loan>();
}
