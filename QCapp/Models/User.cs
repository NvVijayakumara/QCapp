using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? EmailAddress { get; set; }

    public string? Password { get; set; }

    public int? CompanyId { get; set; }

    public string? ContactNumber { get; set; }

    public int? AccessLevelId { get; set; }

    public int? Country { get; set; }

    public int? ClientAssigned { get; set; }

    public int? ProcessAssigned { get; set; }

    public bool? ActiveStatus { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual AccessLevel? AccessLevel { get; set; }

    public virtual ICollection<Audit> AuditCreatedByNavigations { get; set; } = new List<Audit>();

    public virtual ICollection<Audit> AuditModifiedByNavigations { get; set; } = new List<Audit>();

    public virtual Client? ClientAssignedNavigation { get; set; }

    public virtual Company? Company { get; set; }

    public virtual Country? CountryNavigation { get; set; }

    public virtual ICollection<LoansFile> LoansFiles { get; set; } = new List<LoansFile>();

    public virtual Process? ProcessAssignedNavigation { get; set; }

    public virtual ICollection<Questionnaire> Questionnaires { get; set; } = new List<Questionnaire>();
}
