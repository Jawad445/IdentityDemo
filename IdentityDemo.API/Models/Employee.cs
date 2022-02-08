namespace IdentityDemo.API.Models;
using IdentityDemo.Shared.coreEntites;

public class Employee : EntityBase<Guid>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
}

