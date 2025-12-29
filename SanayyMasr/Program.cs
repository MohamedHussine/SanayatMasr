
using System.Diagnostics;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace SanayyMasr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // =====================================================
            // 🗄️ DATABASE (EF Core)
            // =====================================================

            builder.Services.AddDbContext<Context>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("CS"),
                    sql => sql.MigrationsAssembly("SanayyMasr"))
                  .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                  .LogTo(log => Debug.WriteLine(log), LogLevel.Information)
                  .EnableSensitiveDataLogging(true));
            //======================================================


             
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
