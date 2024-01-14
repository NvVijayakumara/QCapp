using System.ComponentModel;

namespace QCapp.ViewModels
{
    public class BillingSummaryViewModel
    {
        [DisplayName("Client Name")]
        public string? ClientName { get; set; }

        [DisplayName("Process Name")]
        public string? ProcessName { get; set; }

        [DisplayName("Billing Month")]
        public string? BillingMonth { get; set; }

        [DisplayName("Total Orders")]
        public string? TotalOrders { get; set; }

        [DisplayName("Billed Amount")]
        public string? BilledAmount { get; set; }
    }
}
