using Microsoft.AspNetCore.Identity;

namespace LoginApp.Models;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime? LastLogin { get; set; }
    public string? ProfilePictureUrl { get; set; }
}