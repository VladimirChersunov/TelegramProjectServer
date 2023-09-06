using server.Models;
using System;
using System.Collections.Generic;

namespace server.Models;

public partial class UserSetting
{
    public int UserId { get; set; }
    public User? User { get; set; }

    public int SettingId { get; set; }
    public Setting? Setting { get; set; }

}
