using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string? MenuName { get; set; }

    public int? Order { get; set; }

    public string? CssClass { get; set; }

    public bool? Active { get; set; }

    public int? ParentMeenuId { get; set; }

    public virtual ICollection<Menu> InverseParentMeenu { get; set; } = new List<Menu>();

    public virtual Menu? ParentMeenu { get; set; }
}
