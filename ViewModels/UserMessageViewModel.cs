using server.Models;

namespace server.ViewModels
{
    public class UserMessageViewModel
    {
        public int Id { get; set; }
        public List<int> WhoViewed { get; set; }
        public string? Data { get; set; }
        public bool DeliveryStatus { get; set; }
        public DateTime SendTime { get; set; }
        public string? Text { get; set; }
        public UserViewModel? Author{ get; set; }
    }
}
