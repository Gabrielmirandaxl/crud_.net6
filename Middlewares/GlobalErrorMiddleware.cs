using System.Net;
using System.Text.Json;

namespace test_crud.Middlewares;
public class GlobalErrorMiddleware
{

  private readonly RequestDelegate next;

  public GlobalErrorMiddleware(RequestDelegate next)
  {
    this.next = next;
  }

  public async Task InvokeAsync(HttpContext httpContext)
  {
    try
    {
      await this.next(httpContext);
    }
    catch (Exception ex)
    {
      await HandleExceptionAsync(httpContext, ex);
    }
  }

  private static Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
  {

    var response = JsonSerializer.Serialize(new { exception.Message });
    httpContext.Response.ContentType = "application/json";
    httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
    return httpContext.Response.WriteAsync(response);
  }


}
