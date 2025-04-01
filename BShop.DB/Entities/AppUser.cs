using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BShop.DB.Entities;

public class AppUser : IdentityUser<Guid>
{
    public AppUser()
    {
        Id = Guid.NewGuid();
        CreatedTime = DateTime.UtcNow;
        Active = true;
    }

    [Required]
    public string FullName { get; set; } = string.Empty;
    
    public Guid CreatedID { get; set; }
    public DateTime CreatedTime { get; set; }
    public Guid? UpdatedID { get; set; }
    public DateTime? UpdatedTime { get; set; }
    public bool Active { get; set; }
}