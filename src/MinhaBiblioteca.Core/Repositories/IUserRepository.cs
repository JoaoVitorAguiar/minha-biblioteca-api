using MinhaBiblioteca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
