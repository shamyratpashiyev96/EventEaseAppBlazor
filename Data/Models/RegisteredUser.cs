using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Data.Models;

public class RegisteredUser
{
    public int Id { get; private set; }

    [Required]
    public string FullName { get; set; }

    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    public string ConfirmPassword { get; set; }
}