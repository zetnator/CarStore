using BookStore_BL.Services;
using CarStore_DL.Interfaces;
using CarStore_DL.Repositories;
using BookstoreApp.HealthChecks;
using CarStore_BL.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace BookstoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IBuyerRepository, AuthorRepository>();

            builder.Services.AddSingleton<IBuyerService, AuthorService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            builder.Services
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
            builder.Services
                .AddValidatorsFromAssemblyContaining(typeof(Program));

            builder.Services
                .AddSingleton<ICarRepository, BookRepository>();

            builder.Services.AddHealthChecks()
                .AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
