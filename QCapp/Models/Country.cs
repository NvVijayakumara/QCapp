using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class Country
{
    public int Id { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Company> CompanyBillingAddressCountryNavigations { get; set; } = new List<Company>();

    public virtual ICollection<Company> CompanyCompanyAddressCountryNavigations { get; set; } = new List<Company>();

    public virtual ICollection<State> States { get; set; } = new List<State>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
