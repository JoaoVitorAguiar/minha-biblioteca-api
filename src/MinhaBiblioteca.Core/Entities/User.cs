using MinhaBiblioteca.Core.Enums;

namespace MinhaBiblioteca.Core.Entities;

public class User : BaseEntity
{
    public User(string name, string email, string passwordHash, Role role)
    {
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;

        Loans = [];
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public Role Role { get; private set; }
    public List<Loan> Loans { get; set; }
}
