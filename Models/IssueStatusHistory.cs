using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CivicReportingAPI.Models
{
    [Table("issue_status_history")]
    public class IssueStatusHistory
    {
        public int Id { get; set; }

        public int IssueId { get; set; }
        public Issue Issue { get; set; }

        public int ChangedBy { get; set; }
        public User ChangedByUser { get; set; }

        public Issue_status? OldStatus { get; set; }
        public Issue_status NewStatus { get; set; }

        public DateTime ChangedAt { get; set; }
    }
}