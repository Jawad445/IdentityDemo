namespace IdentityDemo.API.Services;

using IdentityDemo.API.Services.Interfaces;
using IdentityDemo.Shared;
using IdentityDemo.Shared.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;

public class UserService : IUserService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signinManager;
    private readonly IConfiguration _configuration;
    
    public UserService(UserManager<IdentityUser> userManager, 
        SignInManager<IdentityUser> signinManager,
        IConfiguration configuration)
    {
       _userManager = userManager;
        _signinManager = signinManager;
        _configuration = configuration;
    }
    
    public async Task<Response> RegisterUserAsync(RegisterViewModel model)
    {
        if(model == null)
        {
            throw new NullReferenceException("Register model is null");
        }
        if(model.password != model.confirmPassword)
        {
            return new Response
            {
                Success = false,
                Message = "Confirm password not match with password"
            };
        }

        var user = new IdentityUser
        {
            Email = model.email,
            UserName = $"{model.firstName} {model.lastName}",
            PhoneNumber = model.phoneNumber
        };
        var result  = await _userManager.CreateAsync(user, model.password);
        if (result.Succeeded)
        {
            // Send Confirmation Email
            return new Response
            {
                Message = "user created successfully",
                Success = true
            };
        }
        return new Response
        {
            Message = "user not created",
            Success = false,
            Errors = result.Errors.Select(e => e.Description).ToList()
        };
    }
}

