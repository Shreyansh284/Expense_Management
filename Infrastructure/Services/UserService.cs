using Application.DTOs.UserDTOs;
using Application.Interfaces.Services;
using AutoMapper;
using Core.Entities;
using Core.Interfaces.Repositories;

namespace Infrastructure.Services;

public class UserService(IUserRepository userRepository,IUnitOfWork unitOfWork ,IMapper mapper):IUserService
{
    public async Task AddUserAsync(RegisterUserDTO  registerUserDTO)
    {
        var user = mapper.Map<User>(registerUserDTO);
        await userRepository.AddUserAsync(user);
        await unitOfWork.SaveChangesAsync();
    }

    public async Task<IEnumerable<UserDisplayDTO>> GetAllUserAsync()
    {
        var users = await userRepository.GetAllUserAsync();
        var userDisplayDTO = mapper.Map<IEnumerable<UserDisplayDTO>>(users);
        return userDisplayDTO;
    }
}