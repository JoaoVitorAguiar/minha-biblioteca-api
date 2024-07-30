
using MediatR;

namespace MinhaBiblioteca.Application.Users.Commands.CreateUser;

public class CreateUserCommand: IRequest<Unit>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string passwordhash { get; set; }
}