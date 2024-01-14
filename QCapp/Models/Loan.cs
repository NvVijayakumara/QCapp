using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class Loan
{
    public int LoanId { get; set; }

    public string? LoanNumber { get; set; }

    public string? BorrowerLastName { get; set; }

    public string? CostCenter { get; set; }

    public DateTime? DateSelectedPfqc { get; set; }

    public DateTime? PfqcclearedDate { get; set; }

    public DateTime? AppraisalAcceptedDate { get; set; }

    public bool? Piw { get; set; }

    public bool? UnderwritingDelegated { get; set; }

    public DateTime? LastFinishedMilestoneDate { get; set; }

    public int? LastFinishedMilestone { get; set; }

    public int? CurrentMilestone { get; set; }

    public string? LenderChannel { get; set; }

    public string? LoanFolder { get; set; }

    public int? LoanStatus { get; set; }

    public DateTime? StatusDate { get; set; }

    public DateTime? ApplicationDate { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public DateTime? MilestoneDateDecision { get; set; }

    public DateTime? MilestoneDateResubmittal { get; set; }

    public DateTime? ClosingDate { get; set; }

    public DateTime? DisbursementDate { get; set; }

    public DateTime? FundsSent { get; set; }

    public int? LoanType { get; set; }

    public string? LoanPurpose { get; set; }

    public string? LoanProgram { get; set; }

    public int? Occupancy { get; set; }

    public int? LoanTerm { get; set; }

    public string? AmortizationType { get; set; }

    public string? LienPosition { get; set; }

    public decimal? LoanAmount { get; set; }

    public double? NoteRate { get; set; }

    public decimal? AppraisedValue { get; set; }

    public string? SubjectPropertyType { get; set; }

    public int? SubjectPropertyCity { get; set; }

    public int? SubjectPropertyState { get; set; }

    public string? SubjectPropertyZip { get; set; }

    public double? Cltv { get; set; }

    public int? Fico { get; set; }

    public decimal? TotalGiftFundsAmt { get; set; }

    public double? BottomRatio { get; set; }

    public string? LoanCloser { get; set; }

    public string? LoanOfficer { get; set; }

    public string? LoanProcessor { get; set; }

    public string? Underwriter { get; set; }

    public bool? BorrSelfEmployed { get; set; }

    public bool? CoBorrSelfEmployed { get; set; }

    public string? AgencyCaseNo { get; set; }

    public decimal? IncomeTotalNetRentalIncome { get; set; }

    public int? LoanFileId { get; set; }

    public virtual Milestone? CurrentMilestoneNavigation { get; set; }

    public virtual Milestone? LastFinishedMilestoneNavigation { get; set; }

    public virtual LoansFile? LoanFile { get; set; }

    public virtual LoanStatus? LoanStatusNavigation { get; set; }

    public virtual LoanType? LoanTypeNavigation { get; set; }

    public virtual LoanOccupancy? OccupancyNavigation { get; set; }

    public virtual City? SubjectPropertyCityNavigation { get; set; }

    public virtual State? SubjectPropertyStateNavigation { get; set; }
}
