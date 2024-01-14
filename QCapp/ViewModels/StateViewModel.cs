using QCapp.Models;
using System.ComponentModel;

namespace QCapp.ViewModels
{
    public class StateViewModel : State
    {
        [DisplayName("Country Name")]
        public string? CountryName { get; set; }
    }
}
