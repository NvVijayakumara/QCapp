using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class Billing
{
    public int BillingId { get; set; }

    public int? ClientId { get; set; }

    public int? ProcessId { get; set; }

    public decimal? Pricing { get; set; }

    public DateTime? Date { get; set; }

    public string? OrderNumber { get; set; }

    public string? InvoiceNumber { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Process? Process { get; set; }
}
