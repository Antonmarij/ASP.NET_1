using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public enum ServiceOptions
{
    Option1,
    Option2,
    Option3
}


public class ContactViewModel
{
    [Display(Name = "Full name", Prompt = "Enter your full name")]
    [Required(ErrorMessage = "Your input is invalid")]
    [MinLength(1, ErrorMessage = "Your input is invalid")]
    [DataType(DataType.Text)]
    public string FullName { get; set; } = null!;



    [Display(Name = "Email address", Prompt = "Enter your email")]
    [Required(ErrorMessage = "Your input is invalid")]
    [MinLength(1, ErrorMessage = "Your input is invalid")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    [Display(Name = "Service (Optional)", Prompt = "Choose the service you are interested in")]
    [DataType(DataType.Text)]
    public ServiceOptions? Service { get; set; } = null!;

    [Display(Name = "Message", Prompt = "Enter your message here...")]
    [Required(ErrorMessage = "Your input is invalid")]
    [MinLength(1, ErrorMessage = "Your input is invalid")]
    [DataType(DataType.Text)]
    public string Message { get; set; } = null!;
}
