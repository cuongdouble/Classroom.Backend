using Classroom.Backend.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Filter
{
    public class ApiExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if(context.Exception is BadRequestException)
            {
                context.Result = new BadRequestObjectResult(
                    new ProblemDetails()
                    {
                        Title = "BadRequest",
                        Detail = context.Exception.Message,
                        Status = 400                        
                    });
            }
            else if (context.Exception is UnAuthenticatedException)
            {
                context.Result = new BadRequestObjectResult(
                    new ProblemDetails()
                    {
                        Title = "UnAuthenticated",
                        Detail = context.Exception.Message,
                        Status = 401
                    });
            }
            else if (context.Exception is UnauthorizedException)
            {
                context.Result = new BadRequestObjectResult(
                    new ProblemDetails()
                    {
                        Title = "Forbidden",
                        Detail = context.Exception.Message,
                        Status = 403
                    });
            }
            else if (context.Exception is InternalServiceErrorException)
            {
                context.Result = new BadRequestObjectResult(
                    new ProblemDetails()
                    {
                        Title = "InternalServiceError",
                        Detail = context.Exception.Message,
                        Status = 500
                    });
            }
        }
    }
}
