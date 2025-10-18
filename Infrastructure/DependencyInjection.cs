using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Options;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>((provider, options) =>
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionString>>().Value.DefaultConnection));

          

            // Add HTTP context accessor
            services.AddHttpContextAccessor();

            return services;
        }
    }
}
