using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class City
{
    public int Id { get; set; }

    public int? StateId { get; set; }

    public string? CityName { get; set; }

    public string? CityCode { get; set; }

    public string? Zip { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();

    public virtual State? State { get; set; }
}
