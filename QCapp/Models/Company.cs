using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace QCapp.Models;

public partial class Company
{
    [DisplayName("Company ID")]
    public int CompanyId { get; set; }

    [DisplayName("Company Name")]
    public string CompanyName { get; set; } = null!;

    [DisplayName("Company Code")]
    public string CompanyCode { get; set; } = null!;

    [DisplayName("Company Address Line 1")]
    public string? CompanyAddressLine1 { get; set; }

    [DisplayName("Company Address Line 2")]
    public string? CompanyAddressLine2 { get; set; }

    [DisplayName("Company Address City")]
    public int? CompanyAddressCity { get; set; }

    [DisplayName("Company Address State")]
    public int? CompanyAddressState { get; set; }

    [DisplayName("Company Address Country")]
    public int? CompanyAddressCountry { get; set; }

    [DisplayName("Company Address Zip")]
    public string? CompanyAddressZip { get; set; }

    [DisplayName("Company Email Address")]
    public string? CompanyEmailAddress { get; set; }

    [DisplayName("Billing Address Same As Company")]
    public bool? BillingAdressSameAsCompany { get; set; }

    [DisplayName("Billing Address Line 1")]
    public string? BillingAddressLine1 { get; set; }

    [DisplayName("Billing Address Line 2")]
    public string? BillingAddressLine2 { get; set; }

    [DisplayName("Billing Address Country")]
    public int? BillingAddressCountry { get; set; }

    [DisplayName("Billing Address State")]
    public int? BillingAddressState { get; set; }

    [DisplayName("Billing Address City")]
    public int? BillingAddressCity { get; set; }

    [DisplayName("Billing Address Zip")]
    public string? BillingAddressZip { get; set; }

    [DisplayName("Billing Email Address")]
    public string? BillingEmailAddress { get; set; }

    [DisplayName("Contact Name")]
    public string? ContactName { get; set; }

    [DisplayName("Contact Phone")]
    public string? ContactPhone { get; set; }

    [DisplayName("Created By")]
    public int? CreatedBy { get; set; }

    [DisplayName("Created Date")]
    public DateTime? CreatedDate { get; set; }

    [DisplayName("Modified By")]
    public int? ModifiedBy { get; set; }

    [DisplayName("Modified Date")]
    public DateTime? ModifiedDate { get; set; }

    public virtual Country? BillingAddressCountryNavigation { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual City? CompanyAddressCityNavigation { get; set; }

    public virtual Country? CompanyAddressCountryNavigation { get; set; }

    public virtual State? CompanyAddressStateNavigation { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
