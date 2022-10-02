using Domain;

namespace Application;

public interface IApplication
{
    Task<User[]> GetAllUsersAsync();
    Task AddUserAsync(string name);
}