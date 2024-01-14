using QCapp.Models;
using System.ComponentModel;

namespace QCapp.ViewModels
{
    public class AuditViewModel : Audit
    {
        [DisplayName("Audit Type Name")]
        public string? AuditTypeName { get; set; }

        [DisplayName("Question Batch")]
        public string? QuestionBatch { get; set; }
    }
}
