using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class Questionnaire
{
    public int Id { get; set; }

    public string? QuestionnaireName { get; set; }

    public string? FileName { get; set; }

    public int? UploadedBy { get; set; }

    public DateTime? UploadedDate { get; set; }

    public virtual ICollection<Audit> Audits { get; set; } = new List<Audit>();

    public virtual User? UploadedByNavigation { get; set; }
}
