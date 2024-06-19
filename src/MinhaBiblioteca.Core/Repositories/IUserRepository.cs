using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Core.Repository;

public interface IUserRepository
{
    Task CreateAsync(User user);
    Task<User> GetByIdAsync(Guid id);
    Task<User> GetByEmailAsync(string name);
    Task<IEnumerable<User>> GetUsersAsync();
    Task UpdateAsync(User user);
    Task DeleteAsync(User user);
}
