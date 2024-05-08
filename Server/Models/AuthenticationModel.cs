using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class AuthenticationModel
    {
        [Required]
        [Display(Name = "User Name")]
        [StringLength(16, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
        public string UserName { get; set; } = string.Empty;

        [DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "Minimum length is 4")]
        public string Password { get; set; } = string.Empty;
    }
}