using Microsoft.EntityFrameworkCore;
using Travell.Data;
using Travell.Repositorios;
using Travell.Repositorios.Interface;
using Microsoft.OpenApi.Models;

namespace Travell
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggergen();

            builder.Services.AddEntityFrameworkSqlServer()
               .AddDbContext<TravelDbContext>(
                   options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
               );

            builder.Services.AddScoped<IClienteRepositorio, ClienteRepositorio>

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}