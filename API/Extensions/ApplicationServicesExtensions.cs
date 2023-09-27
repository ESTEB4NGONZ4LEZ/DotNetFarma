
using Aplicacion.UnitOfWork;
using Dominio.Interface;

namespace API.Extensions
{
    public static class ApplicationServicesExtensions 
    {
        public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options => 
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()
                );
        });

        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}