using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class FieldConfiguration
{
    public int FieldId { get; set; }

    public int? FieldSubId { get; set; }

    public string? FieldName { get; set; }

    public string? FieldType { get; set; }

    public int? DocumentId { get; set; }

    public bool? Critical { get; set; }

    public bool? Enable { get; set; }

    public string? Template { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual DocumentConfiguration? Document { get; set; }
}
