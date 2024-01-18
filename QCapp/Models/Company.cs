using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public string? CompanyAddressLine1 { get; set; }

    public string? CompanyAddressLine2 { get; set; }

    public int? CompanyAddressCity { get; set; }

    public int? CompanyAddressState { get; set; }

    public int? CompanyAddressCountry { get; set; }

    public string? CompanyAddressZip { get; set; }

    public string? CompanyEmailAddress { get; set; }

    public bool? BillingAdressSameAsCompany { get; set; }

    public string? BillingAddressLine1 { get; set; }

    public string? BillingAddressLine2 { get; set; }

    public int? BillingAddressCountry { get; set; }

    public int? BillingAddressState { get; set; }

    public int? BillingAddressCity { get; set; }

    public string? BillingAddressZip { get; set; }

    public string? BillingEmailAddress { get; set; }

    public string? ContactName { get; set; }

    public string? ContactPhone { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Country? BillingAddressCountryNavigation { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual City? CompanyAddressCityNavigation { get; set; }

    public virtual Country? CompanyAddressCountryNavigation { get; set; }

    public virtual State? CompanyAddressStateNavigation { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
