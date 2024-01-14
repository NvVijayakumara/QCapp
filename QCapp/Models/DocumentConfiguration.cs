using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class DocumentConfiguration
{
    public int DocumentId { get; set; }

    public int? DocumentSubId { get; set; }

    public string? DocumentName { get; set; }

    public string? ClientDocumentName { get; set; }

    public bool? Critical { get; set; }

    public bool? Enable { get; set; }

    public string? Template { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<FieldConfiguration> FieldConfigurations { get; set; } = new List<FieldConfiguration>();
}
