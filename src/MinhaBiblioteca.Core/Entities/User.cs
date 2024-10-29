
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

        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        Loans = [];
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public IList<Loan> Loans { get; private set; }
    public Role Role { get; private set; }
}
