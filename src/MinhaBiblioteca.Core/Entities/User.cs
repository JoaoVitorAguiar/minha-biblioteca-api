
using MinhaBiblioteca.Core.Enums;

namespace MinhaBiblioteca.Core.Entities;

public class User : BaseEntity
{
    public User() { }
    public User(string name, string email, string passwordHash, Role role)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;

        Books = [];
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public Role Role { get; private set; }
    public ICollection<Book> Books { get; set; }
}
