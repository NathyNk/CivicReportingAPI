using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CivicReportingAPI.Models
{
    [Table("issue_images")]
    public class Issue_Image
    {
        public int Id { get; set; }

        [Required]
        public int IssueId { get; set; }
        public Issue Issue { get; set; }

        [Required]
        [MaxLength(500)]
        public string ImageUrl { get; set; }

        public DateTime UploadedAt { get; set; }
    }
}