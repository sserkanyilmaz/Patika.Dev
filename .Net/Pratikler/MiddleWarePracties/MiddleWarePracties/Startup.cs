using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiddleWarePracties.Middlewares;

namespace MiddleWarePracties
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MiddleWarePracties", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MiddleWarePracties v1"));
            }
                    
            app.UseHttpsRedirection();  

            app.UseRouting();

            app.UseAuthorization();

            //app.Run(); KISA DEVRE YAPTIRIR SONRAKİ MİDDLEWARELER ÇALIŞMAZ
            //app.Run(async context => System.Console.WriteLine("Middleware 1")); 
            //app.Run(async context => System.Console.WriteLine("Middleware 2"));
            //app.Use();//kendi işlemini yapar ve bir sonraki Middleware e aktarım yapar.
            /*app.Use(async(context,next)=>{
                System.Console.WriteLine("Middleware 1 başladı");
                await next.Invoke(); 
                System.Console.WriteLine("MiddleWare 1 Sonlandırılıyor");
            });
            app.Use(async (context, next) =>
            {
                System.Console.WriteLine("Middleware 2 başladı");
                await next.Invoke();
                System.Console.WriteLine("MiddleWare 2 Sonlandırılıyor");
            });
            app.Use(async (context, next) =>
            {
                System.Console.WriteLine("Middleware 3 başladı");
                await next.Invoke();
                System.Console.WriteLine("MiddleWare 3 Sonlandırılıyor");
            });*/
            app.UseHello();
            app.Use(async(context,next)=>{
                System.Console.WriteLine("Use Middleware tetiklendi");
                await next.Invoke();
            });
            //app.map
            app.Map("/example",internalApp=>
            internalApp.Run(async context=>
            {
                Console.WriteLine("/example Middleware tetiklendi" );
                await context.Response.WriteAsync("/example Middleware tetiklendi");
            }));


            //app.MapWhen sadece route a göre degil requestin içindeki herhgangi bir parametreye göre bir middleware yaratmak için 
            app.MapWhen(x=>x.Request.Method=="GET",internalApp=>{
                internalApp.Run(async context=> {
                    Console.WriteLine("MapWhen Middleware tetiklendi.");
                    await context.Response.WriteAsync("MapWhen Middleware tetiklendi.");
                });
            });


            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
 