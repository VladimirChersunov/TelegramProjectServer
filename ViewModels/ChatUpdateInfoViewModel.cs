namespace server.ViewModels
{
    public class ShortMessg
    {
        public int? UserId { get; set; }
        public string? Message { get; set; }
        public string? Username { get; set; }
    }
    public class ChatUpdateInfoViewModel
    {
        public int Id { get; set; }
        public string? ChatImage { get; set; }
        public string? ChatName { get; set; }
        public ShortMessg? ShortMsg { get; set; }
        public DateTime PublishTime { get; set; }
        public List<int> WhoMuted{ get; set; }
        public List<int> Members { get; set; }
        public string? Type { get; set; }
        public int MembersCount { get; set; }
        public int PinnedMessageId { get; set; }
        public string? ChatInfo { get; set; }
        public int AuthorId { get; set; }
        public int NotViewedCounter { get; set; }
    }
}
