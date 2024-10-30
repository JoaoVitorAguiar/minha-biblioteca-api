using MediatR;
using Microsoft.AspNetCore.Mvc;
using MinhaBiblioteca.Application.BookCopies;

namespace MinhaBiblioteca.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BookCopyController : ControllerBase
{
    private readonly IMediator _mediator;

    public BookCopyController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(
            [FromBody] CreateBookCopyCommand command
        )
    {
        await _mediator.Send(command);
        return Created();
    }
}