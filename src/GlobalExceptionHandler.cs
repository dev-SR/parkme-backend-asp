using Domain.Entities.ErrorModel;
using Domain.Entities.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Services.Contracts;

namespace src
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        private readonly ILoggerManager _logger;

        public GlobalExceptionHandler(ILoggerManager logger)
        {
            _logger = logger;
        }

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
                                                    Exception exception,
                                                    CancellationToken cancellationToken)
        {
            var contextFeature = httpContext.Features.Get<IExceptionHandlerFeature>();
            if (contextFeature == null)
                return false;

            var error = contextFeature.Error;

            // Log detailed exception information
            _logger.LogError($"Exception occurred: {error.Message}. StackTrace: {error.StackTrace}");

            // Determine HTTP status code
            int statusCode = DetermineStatusCode(error);

            // Build the standardized error response
            var problemDetails = new ErrorDetails
            {
                StatusCode = statusCode,
                Message = error.Message
            };

            // Handle Identity validation errors
            if (error is IdentityException identityEx)
            {
                HandleIdentityErrors(identityEx, problemDetails);
            }

            // Additional processing for known exception scenarios
            if (error is InvalidOperationException invalidOpEx)
            {
                problemDetails.Message = "Operation is invalid: " + invalidOpEx.Message;
            }
            else if (error is ArgumentException argEx)
            {
                problemDetails.Message = "Invalid argument: " + argEx.Message;
            }
            else if (error.Data["Errors"] is Dictionary<string, List<string>> validationErrors)
            {
                problemDetails.Errors = validationErrors;
            }

            // Write the response
            httpContext.Response.StatusCode = statusCode;
            httpContext.Response.ContentType = "application/json";
            await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);

            return true;
        }

        private int DetermineStatusCode(Exception error)
        {
            return error switch
            {
                KeyNotFoundException => StatusCodes.Status404NotFound,
                InvalidOperationException => StatusCodes.Status400BadRequest,
                ArgumentException => StatusCodes.Status400BadRequest,
                UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
                IdentityException => StatusCodes.Status400BadRequest, // Identity errors treated as BadRequest
                _ => StatusCodes.Status500InternalServerError // Default for unhandled exceptions
            };
        }

        // Handle Identity-related errors like DuplicateEmail, DuplicateUserName
        private void HandleIdentityErrors(IdentityException identityEx, ErrorDetails problemDetails)
        {
            var identityErrors = identityEx.Errors;

            if (identityErrors != null)
            {
                foreach (var error in identityErrors)
                {
                    // Skip "DuplicateUserName" error code
                    if (error.Code == "DuplicateUserName")
                    {
                        continue;
                    }

                    // Collect all other Identity errors
                    if (!problemDetails.Errors.ContainsKey(error.Code))
                    {
                        problemDetails.Errors[error.Code] = new List<string>();
                    }
                    problemDetails.Errors[error.Code].Add(error.Description);
                }
            }
        }

    }
}
