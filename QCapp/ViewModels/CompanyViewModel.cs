using QCapp.Models;
using System.ComponentModel;

namespace QCapp.ViewModels
{
    public class CompanyViewModel : Company
    {
        [DisplayName("Company Address City Name")]
        public string? CompanyAddressCityName { get; set; }

        [DisplayName("Company Address State Name")]
        public string? CompanyAddressStateName { get; set; }

        [DisplayName("Company Address Country Name")]
        public string? CompanyAddressCountryName { get; set; }

        [DisplayName("Billing Address City Name")]
        public string? BillingAddressCityName { get; set; }

        [DisplayName("Billing Address State Name")]
        public string? BillingAddressStateName { get; set; }

        [DisplayName("Billing Address Country Name")]
        public string? BillingAddressCountryName { get; set; }
    }
}
