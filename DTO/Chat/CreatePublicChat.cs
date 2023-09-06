namespace server.DTO.Chat
{

    public class CreatePublicChat
    {
        public string? ChatImage { get; set; }
        public string? ChatName { get; set; }
        public string? Type { get; set; }
        public string? ChatInfo { get; set; }
        public int AuthorId { get; set; }
        public List<int>? Members { get; set; }
    }
}