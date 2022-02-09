using IdentityDemo.Shared;
using IdentityDemo.Shared.ViewModels;

namespace IdentityDemo.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<Response> RegisterUserAsync(RegisterViewModel model);
        //Task<Response> LoginUserAsync(LoginViewModel model);

    }
}
