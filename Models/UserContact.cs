using server.Models;
using System;
using System.Collections.Generic;

namespace server.Models;

public partial class UserContact
{
    public int Id { get; set; }

    public bool NotificationStatus { get; set; }
    public int ContactId { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
}
