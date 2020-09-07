using Microsoft.Extensions.DependencyInjection;

namespace OShop_Identity_Server.Infrastructure
{
    public static class CorsConfig
    {
        public static string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public static string AngularOrigin = "http://localhost:4200";

        public static void RegisterCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins(AngularOrigin)
                                             .AllowAnyHeader()
                                             .AllowAnyMethod()
                                             .AllowAnyOrigin();
                                  });
            });
        }
    }
}
