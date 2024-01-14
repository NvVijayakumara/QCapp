using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class LoansFile
{
    public int Id { get; set; }

    public string? FileName { get; set; }

    public int? StatusId { get; set; }

    public int? TotalLoans { get; set; }

    public int? LoansSuccessCount { get; set; }

    public int? LoansFailedCount { get; set; }

    public int? WorkFlowId { get; set; }

    public int? ProcessId { get; set; }

    public int? AuditId { get; set; }

    public DateTime? UploadedDate { get; set; }

    public int? UpoadedBy { get; set; }

    public virtual Audit? Audit { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();

    public virtual Process? Process { get; set; }

    public virtual LoansFileUploadStatus? Status { get; set; }

    public virtual User? UpoadedByNavigation { get; set; }

    public virtual WorkFlowConfiguration? WorkFlow { get; set; }
}
