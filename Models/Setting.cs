using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace server.Models;

public partial class Setting
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public IList<UserSetting>? UserSettings { get; set; }
}
