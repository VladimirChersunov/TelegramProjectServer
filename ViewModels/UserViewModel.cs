namespace server.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? AboutUser { get; set; }
        public DateTime? LastOnline { get; set; }
        public string? Photo { get; set; }
        public int? MemberId { get; set; }
    }
}
