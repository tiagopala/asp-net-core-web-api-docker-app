using AspNetCoreWebApiDockerApp.Api.Repositories;
using AspNetCoreWebApiDockerApp.Api.Repositories.Context;
using AspNetCoreWebApiDockerApp.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace AspNetCoreWebApiDockerApp.Api.Registers
{
    public static class Configurations
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBooksRepository, BooksRepository>();
        }

        public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LibraryContext>(options =>
                options.UseMySQL(configuration.GetConnectionString("DefaultConnection")));
        }
    }

    public static class RegisterSwagger
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Concepts.Api", Version = "v1" });
            });
        }

        public static void UseDefaultSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Concepts.Api v1");
            });
        }
    }
}
