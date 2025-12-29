using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Text;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using BusinessLogic.Validation.Auth;
using DataAccess.Data;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
namespace SanayyMasr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // =====================================================
            // 🔐 AUTH & SECURITY SERVICES
            // =====================================================

            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<ITokenService, TokenService>();
            builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();

            // =====================================================
            // 🔐 JWT AUTHENTICATION
            // =====================================================

            builder.Services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = builder.Configuration["Jwt:Issuer"],

                        ValidateAudience = true,
                        ValidAudience = builder.Configuration["Jwt:Audience"],

                        ValidateLifetime = true,

                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)
                        )
                    };
                });

            builder.Services.AddAuthorization();

            // =====================================================
            // 🧠 CONTROLLERS + FLUENT VALIDATION
            // =====================================================

            builder.Services.AddControllers()
                .AddFluentValidation(cfg =>
                {
                    cfg.RegisterValidatorsFromAssemblyContaining<RegisterRequestDtoValidator>();
                });
           


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
            // =====================================================
            // 🧩 GENERIC REPOSITORY
            // =====================================================

            builder.Services.AddScoped(
                typeof(IGeneralRepository<>),
                typeof(GeneralRepository<>)
            );

            // =====================================================
            // 🧭 AUTOMAPPER
            // =====================================================

            builder.Services.AddAutoMapper(
                AppDomain.CurrentDomain.GetAssemblies()
            );

            // =====================================================
            // 📦 DOMAIN SERVICES
            // =====================================================

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<ICraftsmanService,CraftsmanService>();
            builder.Services.AddScoped<ICityService, CityService>();
            builder.Services.AddScoped<IGovernorateService, GovernorateService>();
            builder.Services.AddScoped<IProfessionService, ProfessionService>();
            builder.Services.AddScoped<ISkillService, SkillService>();
            builder.Services.AddScoped<ICraftsmanSkillService, CraftsmanSkillService>();
            builder.Services.AddScoped<ICraftsmanCityService, CraftsmanCityService>();
            builder.Services.AddScoped<IGalleryService, GalleryService>();
            builder.Services.AddScoped<IReviewService, ReviewService>();
            builder.Services.AddScoped<IReportService, ReportService>();
            builder.Services.AddScoped<IPaymentService, PaymentService>();
            builder.Services.AddScoped<ISubscriptionPlanService, SubscriptionPlanService>();
            builder.Services.AddScoped<IImageService, CloudinaryImageService>();
            builder.Services.AddScoped<IUserSearchService, UserSearchService>();
            builder.Services.AddScoped<ICraftsmanSearchService, CraftsmanSearchService>();


            // =====================================================
            // 📘 SWAGGER + JWT
            // =====================================================

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new()
                {
                    Title = "SanayyMasr API",
                    Version = "v1"
                });

                c.AddSecurityDefinition("Bearer", new()
                {
                    Name = "Authorization",
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Description = "Bearer {JWT Token}"
                });

                c.AddSecurityRequirement(new()
                {
                    {
                        new()
                        {
                            Reference = new()
                            {
                                Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        Array.Empty<string>()
                    }
                });
            });



            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            // =====================================================
            // 🚀 PIPELINE
            // =====================================================

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthentication(); // 🔓 JWT
            app.UseAuthorization();  // 🔒 [Authorize]

            app.MapGet("/", () => Results.Redirect("/swagger"));
            app.MapControllers();

            app.Run();
        }
    }
}
