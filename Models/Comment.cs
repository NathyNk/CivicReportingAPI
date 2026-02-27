using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CivicReportingAPI.Models
{
    [Table("comments")]
    public class Comment
    {
        public int Id { get; set; }

        public int IssueId { get; set; }
        public Issue Issue { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public string CommentText { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}