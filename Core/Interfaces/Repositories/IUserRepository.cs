using Core.Entities;

namespace Core.Interfaces.Repositories;

public interface IUserRepository
{
    Task AddUserAsync(User user);
    Task<IEnumerable<User>> GetAllUserAsync();
}