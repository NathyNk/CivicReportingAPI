using System.ComponentModel.DataAnnotations;

namespace CivicReportingAPI.Models;

public class Notification
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int? IssueId { get; set; }
    public Issue Issue { get; set; }

    [Required]
    [MaxLength(255)]
    public string Message { get; set; }

    public bool IsRead { get; set; } = false;

    public DateTime CreatedAt { get; set; }
}