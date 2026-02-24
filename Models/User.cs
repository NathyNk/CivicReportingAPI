using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CivicReportingAPI.Models;
public class User
{
    public int Id { get; set; }

    [Required]
    public int RoleId { get; set; }
    public Role Role { get; set; }

    [Required]
    public string FullName { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    public string Phone { get; set; }

    public int? MunicipalityId { get; set; }
    public Municipality Municipality { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public ICollection<Issue> Issues { get; set; }
}