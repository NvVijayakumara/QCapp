using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string? ClientName { get; set; }

    public string? ClientCode { get; set; }

    public int? CompanyId { get; set; }

    public string? ClientAddressLine1 { get; set; }

    public string? ClientAddressLine2 { get; set; }

    public int? ClientAddressCity { get; set; }

    public int? ClientAddressState { get; set; }

    public int? ClientAddressCountry { get; set; }

    public string? ClientAddressZip { get; set; }

    public string? ClientEmailAddress { get; set; }

    public bool? ActiveStatus { get; set; }

    public int? WorkFlowId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Billing> Billings { get; set; } = new List<Billing>();

    public virtual City? ClientAddressCityNavigation { get; set; }

    public virtual Country? ClientAddressCountryNavigation { get; set; }

    public virtual State? ClientAddressStateNavigation { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual WorkFlowConfiguration? WorkFlow { get; set; }
}
