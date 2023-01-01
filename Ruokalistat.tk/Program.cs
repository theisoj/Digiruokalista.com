using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.AspNetCore.Http;
using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using React.AspNet;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.SEOHelper;
using Microsoft.OpenApi.Models;
using Ruokalistat.tk.Models;
using Microsoft.AspNetCore.Identity.UI.Services;



namespace Ruokalistat.tk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Logging.ClearProviders().AddConsole();

            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("fi-FI");
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("fi-FI");

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<tietokantaContext>(options =>
            options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<tietokantaContext>();
            builder.Services.AddControllersWithViews();
            if (!System.OperatingSystem.IsMacOS())
            {
                builder.WebHost.UseUrls("http://*:6669");
            }
            builder.Services.AddTransient<IEmailSender,Special.Mail>();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("all", policy => {
                    policy.AllowAnyHeader().AllowAnyOrigin().Build();
                });
            });
            //builder.Services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Digiruokalista API", Version = "v1" });
            //});
            builder.Services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders =
                    ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
            });
            builder.Services.AddMvcCore();//.AddApiExplorer();
            builder.Services.AddMvc();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //builder.Services.AddReact();
            builder.Services.AddJsEngineSwitcher(options => options.DefaultEngineName = ChakraCoreJsEngine.EngineName).AddChakraCore();

            var app = builder.Build();

            using (var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                //Automaattinen tietokantamigraatio
                scope?.ServiceProvider?.GetService<tietokantaContext>()?.Database.Migrate();
            }


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
                app.UseForwardedHeaders();
            }
            else
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
                app.UseForwardedHeaders();
            }
     
            app.UseHttpsRedirection();
            app.UseStaticFiles();

           
            //app.UseReact(config =>
            //{
            //    TODO: react
            //});

            app.UseCors("all");
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.MapSwagger();
            
            app.MapRazorPages();

            //app.UseSwaggerUI(c =>
            //{
            //    c.RoutePrefix = "swagger";
            //    c.SwaggerEndpoint("v1/swagger.json", "Digiruokalista API v1");
            //    c.DefaultModelsExpandDepth(-1);
            //    c.DefaultModelExpandDepth(-1);
            //});


            app.UseXMLSitemap(app.Environment.ContentRootPath);


            app.Run();
        }

    }
}
