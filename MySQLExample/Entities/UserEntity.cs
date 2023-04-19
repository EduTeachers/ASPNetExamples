using System.ComponentModel.DataAnnotations;

namespace MySQLExample.Entities;

public class UserEntity
{
    public string UserId { get; set; } = Guid.NewGuid().ToString();
    
    public string? FullName { get; set; }
    
    public string? Email { get; set; }
    
}