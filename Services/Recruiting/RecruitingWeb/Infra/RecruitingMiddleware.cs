using Microsoft.AspNetCore.Builder;

namespace RecruitingWeb.Infra;

public class RecruitingMiddleware
{
    private readonly RequestDelegate next;

    public RecruitingMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        string requestMethod = context.Request.Method;
        await next(context);
    }
}


public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseRecreuitingMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RecruitingMiddleware>();
    }
}