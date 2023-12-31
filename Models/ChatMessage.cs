﻿using System;
using System.Collections.Generic;

namespace server.Models;

public partial class ChatMessage
{
    public int ChatId { get; set; }
    public Chat? Chat { get; set; }
    public int MessageId { get; set; }
    public Message? Message { get; set; }
}
