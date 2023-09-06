namespace server.DTO.Message
{

    public class ForwardMessage
    {
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public int UserId { get; set; }
        public int ChatId { get; set; }
    }
}