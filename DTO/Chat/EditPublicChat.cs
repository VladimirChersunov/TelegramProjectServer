namespace server.DTO.Chat
{
    public class EditPublicChat
    {
        public int Id { get; set; }
        public string? ChatImage { get; set; }
        public string? ChatName { get; set; }
        public string? ChatInfo { get; set; }
        public List<int>? Members { get; set; }
    }
}