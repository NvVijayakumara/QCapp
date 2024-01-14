using QCapp.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QCapp.ViewModels
{
    public class UserViewModel : User
    {
        [DisplayName("Company Name")]
        public string? CompanyName { get; set; }

        [DisplayName("Access Level Name")]
        public string? AccessLevelName { get; set; }

        [DisplayName("Country Name")]
        public string? CountryName { get; set; }

        [DisplayName("Client Name")]
        public string? ClientName { get; set; }

        [DisplayName("Process Name")]
        public string? ProcessName { get; set; }

        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }
    }
}
