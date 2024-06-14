using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Core.Repository;

public interface IUserRepository
{
    void Create(User user);
    User GetById(Guid id);
    User GetByEmail(string name);
    IEnumerable<User> GetUsers();
    void Update(User user);
    void Delete(User user);
}
