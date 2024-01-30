using Azure;
using ShopEstre.Application.Common.Dtos;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;

namespace ShopEstre.API.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = new ResponseCustom<string>(error.Message);
               
                switch (error)
                {
                    case ValidationException exception:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        responseModel.Message = exception.ValidationResult.ErrorMessage!;
                        responseModel.Status = (int)HttpStatusCode.BadRequest;
                        break;
                    case KeyNotFoundException exception:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        responseModel.Message = exception.Message!;
                        break;
                    case NullReferenceException exception:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        responseModel.Status = (int)HttpStatusCode.InternalServerError;
                        responseModel.Message = exception.Message;
                        break;

                    case UnauthorizedAccessException exception:
                        response.StatusCode = (int)HttpStatusCode.Unauthorized;
                        responseModel.Status = (int)HttpStatusCode.Unauthorized;
                        responseModel.Message = exception.Message;
                        break;
                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        responseModel.Status = (int)HttpStatusCode.InternalServerError;
                        responseModel.Message = error.Message;
                        break;
                }
                var result = JsonSerializer.Serialize(responseModel);
                await response.WriteAsync(result);
            }
        }

    }
}
