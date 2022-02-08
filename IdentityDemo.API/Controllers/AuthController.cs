namespace IdentityDemo.API.Controllers;

using IdentityDemo.API.Models;
using IdentityDemo.API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[AllowAnonymous]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;
    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync([FromBody] RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _userService.RegisterUserAsync(model);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Errors);
        }
        return BadRequest("Passed model is not valid!");
    }



}

