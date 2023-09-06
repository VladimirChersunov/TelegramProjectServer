namespace server.DTO.Message
{

    public class ReplyToMessage
    {
        public int UserId { get; set; }
        public int ReplyingMessageId { get; set; }
        public string? Text { get; set; }
        public string? Data { get; set; }
    }
}