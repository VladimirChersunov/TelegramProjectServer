using server.Models;
using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        public int? Age { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? UserName { get; set; }
        public string? AboutUser { get; set; }
        [Required]
        public DateTime? LastOnline { get; set; }
        public string? Photo { get; set; }
        public int? MemberId { get; set; }
        public Member? Member { get; set; }
        public ICollection<UserContact>? UserContacts { get; set; }
        public IList<UserSetting>? UserSettings { get; set; }
        public IList<UserRole>? UserRoles { get; set; }
        public IList<UserChat>? UserChats { get; set; }
    }
}
