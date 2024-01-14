using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class WorkFlowConfiguration
{
    public int WorkFlowId { get; set; }

    public string? WorkflowName { get; set; }

    public bool? Indexing { get; set; }

    public bool? IndexingQc { get; set; }

    public bool? DataExtraction { get; set; }

    public bool? DataExtractionQc { get; set; }

    public bool? Checklist { get; set; }

    public bool? ChecklistQc { get; set; }

    public bool? Reverification { get; set; }

    public bool? ReverificationQc { get; set; }

    public bool? Exceptions { get; set; }

    public bool? ExceptionsQc { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<LoansFile> LoansFiles { get; set; } = new List<LoansFile>();
}
