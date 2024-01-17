using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class MenuLink
{
    public int MenuLinkId { get; set; }

    public string? Name { get; set; }

    public string? Href { get; set; }

    public int? Order { get; set; }

    public int? MenuId { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<UserAccessMenuMaping> UserAccessMenuMapings { get; set; } = new List<UserAccessMenuMaping>();
}
