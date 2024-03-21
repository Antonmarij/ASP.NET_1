using System.ComponentModel.DataAnnotations;
using WebApp.Filter;

namespace WebApp.Models;

public class SignUpViewModel
{
    [Display(Name = "First name", Prompt = "Enter your first name")]
    [Required(ErrorMessage = "Your input is invalid")]
    [MinLength(1, ErrorMessage = "Your input is invalid")]
    [DataType(DataType.Text)]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name")]
    [Required(ErrorMessage = "Your input is invalid")]
    [MinLength(1, ErrorMessage = "Your input is invalid")]
    [DataType(DataType.Text)]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email address", Prompt = "Enter your email")]
    [Required(ErrorMessage = "Your input is invalid")]
    [MinLength(1, ErrorMessage = "Your input is invalid")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Your input is invalid")]
    [MinLength(8, ErrorMessage = "Your input is invalid")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name = "Confirm password", Prompt = "Confirm your password")]
    [Required(ErrorMessage = "Your input is invalid")]
    [Compare(nameof(Password), ErrorMessage = "Password does not match")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = null!;

    [Display(Name = "I agree to the terms & conditions")]
    [Required(ErrorMessage = "You must accept the terms & conditions")]
    [CheckboxRequired]
    public bool TermsAndConditions { get; set; }
}
