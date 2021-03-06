using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Session;

namespace week_6
{
    public class Startup
    {
        public static IConfiguration StaticConfig { get; private set; }

        public Startup(IConfiguration configuration)
        {
            StaticConfig = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CustomClasses.SiteConfiguration>(StaticConfig);
            services.Configure<CustomClasses.SiteConfiguration>(StaticConfig.GetSection("Subtitles"));
            services.Configure<CustomClasses.SiteConfiguration>(StaticConfig.GetSection("Logging").GetSection("LogLevel"));
            services.AddMvc();

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(120*60);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
        }

    

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IOptions<CustomClasses.SiteConfiguration> optionsAccessor)
        {
            CustomClasses.GlobalFunctions.siteConfig = optionsAccessor.Value;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
              
                app.UseExceptionHandler("/Error");
            }

            app.UseSession();

            app.UseCookiePolicy();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
            });

            // app.UseStatusCodePages();

            app.UseStatusCodePagesWithRedirects("/Error/Http?statusCode={0}");

            //app.UseStatusCodePages(async context =>
            //{
            //    context.HttpContext.Response.ContentType = "text/html";

            //    if (context.HttpContext.Response.StatusCode == 404)
            //    {
            //        // Log this error here, e.g. to a database. You can use the context.HttpContext.Request 
            //        // object to access important information like the requested URL
            //    }

            //    await context.HttpContext.Response.WriteAsync(
            //        "We're <b>really</b> sorry, but something went wrong. Error code: " +
            //        context.HttpContext.Response.StatusCode);
            //});

            app.UseStaticFiles(); // For the wwwroot folder           
       
            app.UseDirectoryBrowser(new DirectoryBrowserOptions
            {
                FileProvider = new PhysicalFileProvider
                (
                    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")
                ),
                RequestPath = "/Images"
            });

    
            //app.UseHttpContextItemsMiddleware();
        }


    }
}
