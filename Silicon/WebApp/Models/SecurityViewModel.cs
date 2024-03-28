using System.ComponentModel.DataAnnotations;
using WebApp.Filter;

namespace WebApp.Models1;

public class SecurityViewModel
{

    [Display(Name = "Current password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Your input is invalid")]
    [MinLength(8, ErrorMessage = "Your input is invalid")]
    [DataType(DataType.Password)]
    public string CurrentPassword { get; set; } = null!;

    [Display(Name = "New password", Prompt = "Enter your new password")]
    [Required(ErrorMessage = "Your input is invalid")]
    [MinLength(8, ErrorMessage = "Your input is invalid")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name = "Confirm new password", Prompt = "Confirm your new password")]
    [Required(ErrorMessage = "Your input is invalid")]
    [Compare(nameof(Password), ErrorMessage = "Password does not match")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = null!;

    [Display(Name = "Yes, I want to delete my account.")]
    [CheckboxRequired]
    public bool DeleteAccount { get; set; }
}
