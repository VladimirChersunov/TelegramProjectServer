using server.Models;
using System;
using System.Collections.Generic;

namespace server.Models;

public partial class UserRole
{
    public int UserId { get; set; }
    public User? User { get; set; }
    public int RoleId { get; set; }
    public Role? Role { get; set; }

}
