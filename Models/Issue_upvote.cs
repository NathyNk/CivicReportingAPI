namespace CivicReportingAPI.Models;

public class Issue_upvote
{
    public int Id { get; set; }

    public int IssueId { get; set; }
    public Issue Issue { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public DateTime CreatedAt { get; set; }
}