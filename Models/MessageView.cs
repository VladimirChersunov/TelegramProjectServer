using Microsoft.Build.Framework;

namespace server.Models
{
    public class MessageView
    {
        public int MessageId { get; set; }
        public Message? Message { get; set; } 
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
