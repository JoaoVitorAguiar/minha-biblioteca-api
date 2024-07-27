using MediatR;
using Microsoft.AspNetCore.Mvc;
using MinhaBiblioteca.Application.Books.Commands.CreateBookCommand;

namespace MinhaBiblioteca.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly IMediator _mediator;

    public BookController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Post(
        [FromBody] CreateBookCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
}
