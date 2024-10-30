using MediatR;
using Microsoft.AspNetCore.Mvc;
using MinhaBiblioteca.Application.Books;
using MinhaBiblioteca.Application.Books.Commands.CreateBook;
using MinhaBiblioteca.Application.Books.Queries.GetBookByISBN;

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

    [HttpGet("isbn")]
    public async Task<IActionResult> GetByIsbn(
     [FromQuery] GetBookByISBNQuery command)
    {
        var book = await _mediator.Send(command);
        return Ok(book);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(
        [FromQuery] GetAllBooksQuery command)
    {
        var books = await _mediator.Send(command);
        return Ok(books);
    }

}
