using QCapp.Models;
using System.ComponentModel;

namespace QCapp.ViewModels
{
    public class BillingViewModel : Billing
    {
        [DisplayName("Client Name")]
        public string? ClientName { get; set; }

        [DisplayName("Process Name")]
        public string? ProcessName { get; set; }
    }
}
