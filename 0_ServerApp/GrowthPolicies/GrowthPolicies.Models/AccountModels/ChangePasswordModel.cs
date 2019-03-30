using System.ComponentModel.DataAnnotations;

namespace GrowthPolicies.Models.AccountModels
{
    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The field {0} must have at least {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new passsword")]
        [Compare("NewPassword", ErrorMessage = "Both password doesn't match.")]
        public string ConfirmPassword { get; set; }

    }
}
