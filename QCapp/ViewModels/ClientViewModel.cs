using QCapp.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QCapp.ViewModels
{
    public class ClientViewModel : Client
    {
        [DisplayName("Company Name")]
        public string? CompanyName { get; set; }

        [DisplayName("Client Address City Name")]
        public string? ClientAddressCityName { get; set; }

        [DisplayName("Client Address State Name")]
        public string? ClientAddressStateName { get; set; }

        [DisplayName("Client Address Country Name")]
        public string? ClientAddressCountryName { get; set; }

        [DisplayName("Work Flow Name")]
        public string? WorkFlowName { get; set; }
    }
}
