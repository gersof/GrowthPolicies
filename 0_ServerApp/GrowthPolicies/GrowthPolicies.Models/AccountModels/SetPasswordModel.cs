using System.ComponentModel.DataAnnotations;

namespace GrowthPolicies.Models.AccountModels
{
    public class SetPasswordModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The field {0} must have at least {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "Both password doesn't match.")]
        public string ConfirmPassword { get; set; }
    }
}
