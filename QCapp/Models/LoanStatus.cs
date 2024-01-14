using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class LoanStatus
{
    public int LoanStatusId { get; set; }

    public string? LoanStatusName { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
