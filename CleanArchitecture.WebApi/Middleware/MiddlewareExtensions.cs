namespace CleanArchitecture.WebApi.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddlewareExtensions(this IApplicationBuilder application)
        {
            application.UseMiddleware<ExceptionMiddleware>();
            return application;
        }
    }
}
