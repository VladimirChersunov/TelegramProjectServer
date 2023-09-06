namespace server.Models
{
    public class ChatMute
    {
        public int ChatId { get; set; }
        public Chat? Message { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
