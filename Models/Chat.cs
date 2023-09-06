using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using server.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace server.Models;

public partial class Chat
{
    public int Id { get; set; }

    public string? ChatImage { get; set; }

    public string? ChatName { get; set; }
    public string? ShortMessage { get; set; }
    public DateTime PublishTime { get; set; }

    [Required]
    public string? Type { get; set; }

    [Required] 
    public int MembersCount { get; set; }
    public int? PinnedMessageId { get; set; }
    public string? ChatInfo { get; set; }
    public int? AuthorId { get; set; }
    public IList<ChatMessage>? ChatMessages { get; set; }
    public IList<UserChat>? UserChats { get; set; }
}
