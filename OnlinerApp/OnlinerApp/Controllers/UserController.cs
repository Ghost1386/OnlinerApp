using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.UserDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly ILogger<UserController> _logger;

    public UserController(IUserService userService, ILogger<UserController> logger)
    {
        _userService = userService;
        _logger = logger;
    }
    
    [HttpGet("/get/user")]
    public List<User> Get()
    {
        return _userService.Get().ToList();
    }
    
    [HttpGet("/get/user/{id}")]
    public User Get(int id)
    {
        return _userService.Get(id);
    }
    
    [HttpGet("/get/user/{email, password}")]
    public User Get(string email, string password)
    {
        return _userService.Get(email, password);
    }
    
    [HttpPost("/create/user")]
    public IActionResult Create(CreateUserDTO model)
    {
        _userService.Create(model);
        
        _logger.LogInformation($"Create new user");
            
        return Ok();
    }
    
    [HttpPut("/put/user")]
    public IActionResult Edit(int id, EditUserDTO model)
    {
        _userService.Edit(id, model);
        
        _logger.LogInformation($"Edit user {id}");

        return Ok();
    }
    
    [HttpDelete("/delete/user")]
    public IActionResult Delete(DeleteUserDTO model)
    {
        _userService.Delete(model);
        
        _logger.LogInformation($"Delete computer {model.Email}");

        return Ok();
    }
}