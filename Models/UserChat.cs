using Microsoft.Build.Framework;

namespace server.Models
{
    public class UserChat
    {
        [Required]
        public int UserId { get; set; }
        public User? User { get; set; }

        [Required]
        public int ChatId { get; set; }

        public Chat? Chat { get; set; }

    }
}
