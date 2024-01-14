using QCapp.Models;
using System.ComponentModel;

namespace QCapp.ViewModels
{
    public class QuestionnaireViewModel : Questionnaire
    {
        [DisplayName("Uploaded By")]
        public string? UploadedByName { get; set; }
    }
}
