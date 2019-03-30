using System.ComponentModel.DataAnnotations;

namespace GrowthPolicies.Models.AccountModels
{
    public class RegisterModel
    {

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The field {0} must have at least {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Both password doesn't match.")]
        public string ConfirmPassword { get; set; }
    }
}
