using QCapp.Models;
using System.ComponentModel;

namespace QCapp.ViewModels
{
    public class LoansFileViewModel : LoansFile
    {
        [DisplayName("Status")]
        public string? LoanUploadStatusName { get; set; }

        [DisplayName("Work Flow Name")]
        public string? WorkFlowName { get; set; }

        [DisplayName("Process Name")]
        public string? ProcessName { get; set; }

        [DisplayName("Audit Name")]
        public string? AuditName { get; set; }
    }
}
