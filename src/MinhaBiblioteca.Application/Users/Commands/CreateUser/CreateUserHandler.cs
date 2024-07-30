

using MediatR;
using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Enums;
using MinhaBiblioteca.Core.Exceptions;
using MinhaBiblioteca.Core.Repositories;

namespace MinhaBiblioteca.Application.Users.Commands.CreateUser;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, Unit>
{
    private readonly IUserRepository _userRepository;

    public CreateUserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByEmailAsync(request.Email);
        if (user != null) { throw new AlreadyExistsException(typeof(User)); }
        var newUser = new User(request.Name, request.Email, request.passwordhash, Role.CLIENT);
        await _userRepository.CreateAsync(newUser);
        return Unit.Value;
    }
}
