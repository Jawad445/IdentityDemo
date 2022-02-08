namespace IdentityDemo.API.Models;
using System.ComponentModel.DataAnnotations;

#nullable enable
public class RegisterViewModel
{
    [Required]
    [Display(Name ="First Name")]
    public string firstName { get; set; }
    [Required]
    [Display(Name = "Last Name")]
    public string lastName { get; set; }
    [Required, EmailAddress]
    public string email { get; set; }
    [DataType(DataType.PhoneNumber)]
    public string phoneNumber { get; set; }
    [Required, MinLength( 5)]
    [DataType(DataType.Password)]
    public string password { get; set; }
    [Required, MinLength(5)]
    [Compare("password")]
    public string confirmPassword { get; set; }
}

