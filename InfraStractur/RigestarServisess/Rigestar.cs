using Authentication.auth;
using InfraStractur.Repository.RepositoryDeleted;
using InfraStractur.RepositoryModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Model_Entity.Models;

namespace InfraStractur.RigestarServisess
{
    public static class Rigestar
    {

        public static void Cros_Angular(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200")
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    }
                    );
            });
        }
        public static void RigestarToken(IServiceCollection services)
        {
            services.AddSingleton<ITokenService, TokenService>();


            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<UserRepository>();

            services.AddScoped<CourseRepository>();

            services.AddScoped<UserCourseRepository>();


            //services.AddScoped<IServisesRepository<User, UserSummary>, ServisesRepository<User, UserSummary>>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = JwtService.GetValidationParameters();
                });
        }
    }
}
