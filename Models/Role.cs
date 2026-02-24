using System.ComponentModel.DataAnnotations;
namespace CivicReportingAPI.Models;
public class Role
{
   
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public ICollection<User> Users { get; set; }
}