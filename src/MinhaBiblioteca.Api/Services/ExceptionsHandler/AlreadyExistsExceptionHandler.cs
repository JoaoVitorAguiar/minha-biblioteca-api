using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinhaBiblioteca.Core.Exceptions;

namespace MinhaBiblioteca.Api.Services.ExceptionsHandler;

public class AlreadyExistsExceptionHandler : IExceptionHandler
{
    private readonly ILogger<AlreadyExistsExceptionHandler> _logger;

    public AlreadyExistsExceptionHandler(ILogger<AlreadyExistsExceptionHandler> logger)
    {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        if (exception is not AlreadyExistsException alreadyExistsException)
        {
            return false;
        }

        _logger.LogError(
            alreadyExistsException,
            "Exception occurred: {Message}",
            alreadyExistsException.Message);

        var problemDetails = new ProblemDetails
        {
            Status = StatusCodes.Status409Conflict,
            Title = "Conflict",
            Detail = alreadyExistsException.Message
        };

        httpContext.Response.StatusCode = problemDetails.Status.Value;

        await httpContext.Response
            .WriteAsJsonAsync(problemDetails, cancellationToken);

        return true;
    }
}
