using Server.Infrastructure.Validation;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Domain;

public class ApplicationUser : IdentityUser<string>
{

    [Display(Name = "Full Name")]
    [StringLength(255, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
    public string FullName { get; set; } = string.Empty;

    // public string Image { get; set; } = string.Empty;

    // [NotMapped]
    // [PhotoExtension]
    // public IFormFile? ImageUpload { get; set; }

    public virtual ICollection<ApplicationUserRole> UserRoles { get; set; } = [];
}
