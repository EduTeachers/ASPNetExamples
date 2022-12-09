using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormExample.FormModel;

public class RegisterUserFormModel
{
    [Required]
    public string FullName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [PasswordPropertyText]
    [MinLength(6)]
    public string Password { get; set; }
}