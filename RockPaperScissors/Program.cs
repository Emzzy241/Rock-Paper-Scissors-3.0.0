using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using RockPaperScissors.Models;


namespace RockPaperScissors.Models
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            // Writing ASP.NET MVC 6 pipeline
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();


        }
    }
}