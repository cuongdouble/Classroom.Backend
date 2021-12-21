using Classroom.Backend.Contracts;
using Classroom.Backend.Entity;
using Classroom.Backend.Repository;
using Classroom.Backend.Services;
using Classroom.Backend.Services.EmailService;
using CompanyEmployees.JwtFeatures;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CompanyEmployees.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

        public static void ConfigureSqlContext(this IServiceCollection services) =>
            services.AddDbContext<RepositoryContext>(opts =>
            {
                //var folder = Environment.SpecialFolder.ApplicationData;
                //var path = Environment.GetFolderPath(folder);
                //var dbPath = System.IO.Path.Join(path, "Classroom.db");
                opts.UseSqlite($"Data Source=Classroom.db");
            });

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<JwtHandler>();
            services.AddScoped<IEmailSender, EmailSender>();
        }
          
    }
}
