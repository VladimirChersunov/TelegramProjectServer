using System.ComponentModel;

namespace server.ViewModels
{
    public class MessageViewModel
    {
        public int Id { get; set; }
        public List<int> WhoViewed { get; set; }
        public string? Data { get; set; }
        public bool DeliveryStatus { get; set; }
        public DateTime SendTime { get; set; }
        public string? Text { get; set; }
        public int UserId { get; set; }
    }
}
