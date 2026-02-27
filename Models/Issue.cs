using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CivicReportingAPI.Models
{
    [Table("issues")]
    public class Issue
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int MunicipalityId { get; set; }
        public Municipality Municipality { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Category { get; set; }

        [Column(TypeName = "decimal(10,8)")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "decimal(11,8)")]
        public decimal Longitude { get; set; }

        public Issue_status Status { get; set; } = Issue_status.Reported;

        public int PriorityScore { get; set; } = 0;

        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Issue_Image> Images { get; set; } = new List<Issue_Image>();
        public ICollection<Issue_upvote> Upvotes { get; set; } = new List<Issue_upvote>();
        public ICollection<IssueStatusHistory> StatusHistory { get; set; } = new List<IssueStatusHistory>();
    }
}