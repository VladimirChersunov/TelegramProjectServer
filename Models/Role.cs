using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace server.Models;

public partial class Role
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public ICollection<Member>? Members { get; set; }
    public IList<UserRole>? UserRoles { get; set; }
}
