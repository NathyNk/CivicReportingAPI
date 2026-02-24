using System.ComponentModel.DataAnnotations;
namespace CivicReportingAPI.Models;
public class Municipality
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Province { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public ICollection<Issue> Issues { get; set; }
}