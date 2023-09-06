using Microsoft.Build.Framework;
using server.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace server.Models;

public partial class Message
{
    public int Id { get; set; }
    public string? Data { get; set; }
    [DefaultValue(false)]
    public bool DeliveryStatus { get; set; }
    [Required]
    public DateTime SendTime { get; set; }
    [Required]
    public string? Text { get; set; }
    [Required]
    public int UserId { get; set; }
    public User? User { get; set; }
    public IList<ChatMessage>? ChatMessages { get; set; }
}
