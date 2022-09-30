using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MiddleWarePracties.Middlewares{
    public class HelloMiddleware{
        private readonly RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public  async Task Invoke(HttpContext context){
            Console.WriteLine("Hello World");
            await _next.Invoke(context);
            System.Console.WriteLine("Bye World");
        }
    }
    public static class HelloMiddleWareExtension{
        public static IApplicationBuilder UseHello(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HelloMiddleware>();
        }
    }
}