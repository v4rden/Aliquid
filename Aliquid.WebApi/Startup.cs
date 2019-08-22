namespace Aliquid.WebApi
{
    using System.Reflection;
    using Application;
    using Application.Interfaces;
    using MediatR;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMediatR(typeof(GetChangeRequestHandler).GetTypeInfo().Assembly);
            services.AddTransient<IChangeCalculator, ChangeCalculator>();
            services.AddTransient<IDeckAnalyzer, DeckAnalyzer>();

            services.AddMvc();
            services.AddSwaggerDocument();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseOpenApi();
            app.UseSwaggerUi3(options =>
                {
                    // Define web UI route
                    options.Path = "/swagger";

                    // Define OpenAPI/Swagger document route (defined with UseSwaggerWithApiExplorer)
                    options.DocumentPath = "/swagger/v1/swagger.json";
                }
            );

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "default",
                    "{controller}/{action=Index}/{id?}");
            });
        }
    }
}