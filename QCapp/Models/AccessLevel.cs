using System;
using System.Collections.Generic;

namespace QCapp.Models;

public partial class AccessLevel
{
    public int AccessLevelId { get; set; }

    public string AccessLevelName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
