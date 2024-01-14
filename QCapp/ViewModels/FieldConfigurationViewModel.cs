using QCapp.Models;
using System.ComponentModel;

namespace QCapp.ViewModels
{
    public class FieldConfigurationViewModel : FieldConfiguration
    {
        [DisplayName("Document Name")]
        public string? DocumentName { get; set; }
    }
}
