using IdentityDemo.API.Models;
using IdentityDemo.Shared;

namespace IdentityDemo.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<Response> RegisterUserAsync(RegisterViewModel model);
    }
}
