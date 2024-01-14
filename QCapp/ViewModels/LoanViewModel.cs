using QCapp.Models;
using System.ComponentModel;

namespace QCapp.ViewModels
{
    public class LoanViewModel : Loan
    {
        [DisplayName("Last Finished Milestone")]
        public string? LastFinishedMilestone { get; set; }

        [DisplayName("Current Milestone")]
        public string? CurrentMilestone { get; set; }

        [DisplayName("Loan Status")]
        public string? LoanStatus { get; set; }

        [DisplayName("Loan Type")]
        public string? LoanType { get; set; }

        [DisplayName("Occupancy")]
        public string? Occupancy { get; set; }

        [DisplayName("Subject Property City")]
        public string? SubjectPropertyCity { get; set; }

        [DisplayName("Subject Property State")]
        public string? SubjectPropertyState { get; set; }

        [DisplayName("Audit Name")]
        public string? AuditName { get; set; }

        [DisplayName("Process Name")]
        public string? ProcessName { get; set; }

        [DisplayName("WorkFlow Name")]
        public string? WorkFlowName { get; set; }
    }
}
