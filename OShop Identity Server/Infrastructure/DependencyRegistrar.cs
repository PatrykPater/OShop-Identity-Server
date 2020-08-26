using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OShop_Identity_Server.Infrastructure
{
    public static class DependencyRegistrar
    {
        public static void RegisterApiServices(this IServiceCollection services)
        {
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
