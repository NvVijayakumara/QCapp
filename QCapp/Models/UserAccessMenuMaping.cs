using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class UserAccessMenuMaping
{
    public int MappingId { get; set; }

    public int? AccessLevelId { get; set; }

    public int? MenuLinkId { get; set; }

    public virtual AccessLevel? AccessLevel { get; set; }

    public virtual MenuLink? MenuLink { get; set; }
}
