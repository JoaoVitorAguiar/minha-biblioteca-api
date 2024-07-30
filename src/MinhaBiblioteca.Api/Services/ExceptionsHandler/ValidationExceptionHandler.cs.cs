using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;

namespace MinhaBiblioteca.Api.Services.ExceptionsHandler;

public class ValidationExceptionHandler : IExceptionHandler
{
    private readonly ILogger<ValidationExceptionHandler> _logger;

    public ValidationExceptionHandler(ILogger<ValidationExceptionHandler> logger)
    {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        if (exception is not ValidationException fluentException)
        {
            return false; 
        }

        var problemDetails = new ProblemDetails
        {
            Title = "One or more validation errors occurred.",
            Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
            Status = StatusCodes.Status400BadRequest,
            Instance = httpContext.Request.Path
        };

        var validationErrors = fluentException.Errors.Select(e => e.ErrorMessage).ToList();
        problemDetails.Extensions.Add("errors", validationErrors);

        _logger.LogError("{ProblemDetailsTitle}", problemDetails.Title);

        httpContext.Response.StatusCode = problemDetails.Status.Value;
        await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken).ConfigureAwait(false);
        return true;
    }
}
