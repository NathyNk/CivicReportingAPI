using System.ComponentModel.DataAnnotations;
namespace CivicReportingAPI.Models;
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
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }

    public string Category { get; set; }

    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }

    public string Status { get; set; } = "Reported";

    public int PriorityScore { get; set; } = 0;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}