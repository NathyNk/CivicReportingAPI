using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CivicReportingAPI.Models
{
    [Table("users")]
    public class User
    {
        public int Id { get; set; }

        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        public int? MunicipalityId { get; set; }
        public Municipality Municipality { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; }

        public ICollection<Issue> Issues { get; set; } = new List<Issue>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Issue_upvote> Upvotes { get; set; } = new List<Issue_upvote>();
        public ICollection<IssueStatusHistory> StatusChanges { get; set; } = new List<IssueStatusHistory>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }
}