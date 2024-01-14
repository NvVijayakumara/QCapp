using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class LoansFileUploadStatus
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<LoansFile> LoansFiles { get; set; } = new List<LoansFile>();
}
