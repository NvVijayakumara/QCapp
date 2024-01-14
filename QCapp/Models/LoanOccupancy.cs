using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class LoanOccupancy
{
    public int Id { get; set; }

    public string? Value { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
