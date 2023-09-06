namespace server.DTO.Chat
{
    public class SetPinnedMessage
    {
        public string? Action { get; set; }
        public int? MessageId { get; set; }
        public int ChatId { get; set; }
    }
}