namespace WebApplication1
{
    public class MiddlewareCustom : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            

            return next.Invoke(context);
        }
    }
}
