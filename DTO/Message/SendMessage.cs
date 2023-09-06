namespace server.DTO.Message
{

    public class SendMessage
    {
        public int UserId { get; set; }
        public int ChatId { get; set; }
        public string? Data { get; set; }
        public string? Text { get; set; }
    }
}