using MediatR;
using Microsoft.AspNetCore.Mvc;
using MinhaBiblioteca.Application.Loans.Commands.CreateLoan;

namespace MinhaBiblioteca.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LoanController : ControllerBase
{
    private readonly IMediator _mediator;
    public LoanController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreateLoanCommand command)
    {
        await _mediator.Send(command);  
        return Ok();
    }
}
