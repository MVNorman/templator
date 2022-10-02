using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class UserController : ControllerBase
{
    private readonly IApplication _application;

    public UserController(IApplication application)
    {
        _application = application;
    }

    [HttpGet("all")]
    public async Task<User[]> GetAll()
    {
        return await _application.GetAllUsersAsync();
    }

    [HttpPost("")]
    public async Task Add([FromBody] string name)
    {
        await _application.AddUserAsync(name);
    }
}