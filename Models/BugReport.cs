using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace server.Models
{
    public class BugReport
    {
        public int Id { get; set; }

        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? BugTitle { get; set; }

        public string? BugDescription { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
