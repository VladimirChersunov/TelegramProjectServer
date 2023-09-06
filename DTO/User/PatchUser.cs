namespace server.DTO.User
{
    public class PatchUser
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? About { get; set; }
        public int? Age { get; set; }
        public string? Photo { get; set; }
    }

}