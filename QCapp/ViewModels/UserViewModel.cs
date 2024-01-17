using QCapp.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QCapp.ViewModels
{
    public class UserSiteDetailsViewModel
    {
        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        public List<UserLink> UserLinks { get; set; }
    }
    
    public class UserLink
    {
        // menus
        public int? MenuId { get; set; }
        public string? MenuName { get; set; }
        public int? ParentMenuId { get; set; }
        public int? MenuOrder { get; set; }
        public string? MenuCssClass { get; set; }

        //menu links
        public int? LinkId { get; set; }
        public string? LinkName { get; set; }
        public string? LinkHref { get; set; }
        public int? LinkOrder { get; set; }
    }

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
