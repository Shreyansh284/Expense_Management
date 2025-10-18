using Application.DTOs.UserDTOs;
using Application.Interfaces.Services;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using WebApi.Comman;

namespace WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService userService):ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetUserAsync()
    {
        var users=await userService.GetAllUserAsync();
        return Ok(ApiResponse<object>.Success(users, "User Fetched successfully"));
    }
    [HttpPost]
    public async Task<IActionResult> AddUserAsync([FromBody] RegisterUserDTO registerUserDto)
    {
        await userService.AddUserAsync(registerUserDto);
        return Ok(ApiResponse<object>.Success("User created successfully"));
    }

}