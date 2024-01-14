using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class Checklist
{
    public int ChecklistId { get; set; }

    public string QuestionCode { get; set; } = null!;

    public string? Question { get; set; }

    public string? ExceptionCategoryName { get; set; }

    public string? FnmacategoryName { get; set; }

    public string? FnmasubCategoryName { get; set; }

    public string? ExceptionName { get; set; }

    public int? QuestionCategory1 { get; set; }

    public int? QuestionCategory2 { get; set; }

    public int? QuestionCategory3 { get; set; }

    public int? QuestionCategory4 { get; set; }

    public int? QuestionCategory5 { get; set; }

    public int? QuestionCategory6 { get; set; }

    public int? QuestionCategory7 { get; set; }

    public int? QuestionCategory8 { get; set; }

    public int? QuestionCategory9 { get; set; }

    public int? ResponsibleUnit { get; set; }

    public int? Significance { get; set; }

    public string? Template { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
