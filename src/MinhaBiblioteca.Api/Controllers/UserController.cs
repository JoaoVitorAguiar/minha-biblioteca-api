using MediatR;
using Microsoft.AspNetCore.Mvc;
using MinhaBiblioteca.Application.Users.Commands.CreateUser;

namespace MinhaBiblioteca.Api.Controllers;

[ApiController]
[Route("[Controller]")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Register(
        [FromBody] CreateUserCommand command)
    {
        await _mediator.Send(command);
        return Created();
    }
}
