using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class Audit
{
    public int AuditId { get; set; }

    public string? AuditName { get; set; }

    public DateTime? AuditStartDate { get; set; }

    public DateTime? AuditEndDate { get; set; }

    public int? AuditTypeId { get; set; }

    public int? QuestionnaireId { get; set; }

    public DateTime? AuditDueDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual AuditType? AuditType { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<LoansFile> LoansFiles { get; set; } = new List<LoansFile>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual Questionnaire? Questionnaire { get; set; }
}
