using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinhaBiblioteca.Core.Exceptions;

namespace MinhaBiblioteca.Api.Services.ExceptionsHandler;

public class NotAvaliableHandler : IExceptionHandler
{
    private readonly ILogger<NotAvaliableHandler> _logger;

    public NotAvaliableHandler(ILogger<NotAvaliableHandler> logger)
    {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        if (exception is not NotAvailableException notAvailableException)
        {
            return false;
        }

        _logger.LogError(
            notAvailableException,
            "Exception occurred: {Message}",
            notAvailableException.Message);

        var problemDetails = new ProblemDetails
        {
            Status = StatusCodes.Status404NotFound,
            Title = "Resource Not Available",
            Detail = notAvailableException.Message
        };

        httpContext.Response.StatusCode = problemDetails.Status.Value;

        await httpContext.Response
            .WriteAsJsonAsync(problemDetails, cancellationToken);

        return true;
    }
}
