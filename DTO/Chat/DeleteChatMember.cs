namespace server.DTO.Chat
{
    public class DeleteChatMember
    {
        public int Id { get; set; }
        public List<int>? Members { get; set; }
    }
}