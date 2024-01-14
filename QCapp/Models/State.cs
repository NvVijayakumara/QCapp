using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class State
{
    public int Id { get; set; }

    public int? CountryId { get; set; }

    public string? StateName { get; set; }

    public string? StateCode { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
