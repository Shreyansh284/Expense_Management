using Application.DTOs.UserDTOs;
using Core.Entities;

namespace Application.Interfaces.Services;

public interface IUserService
{
    Task AddUserAsync(RegisterUserDTO registerUserDTO);
    Task<IEnumerable<UserDisplayDTO>> GetAllUserAsync();
}