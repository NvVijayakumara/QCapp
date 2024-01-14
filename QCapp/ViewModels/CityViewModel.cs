using QCapp.Models;
using System.ComponentModel;

namespace QCapp.ViewModels
{
    public class CityViewModel : City
    {
        [DisplayName("Country Name")]
        public string? CountryName { get; set; }

        [DisplayName("State Name")]
        public string? StateName { get; set; }
    }
}
