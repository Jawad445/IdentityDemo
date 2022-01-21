using IdentityDemo.Shared.coreEntites;

namespace IdentityDemo.API.Models
{
    public class Employee : EntityBase<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
