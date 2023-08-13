using BMS.Persistence.ApplicationDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Persistence
{
    public static class PersistenceConfiguration
    {
        public static IServiceCollection RegisterPersistence(this IServiceCollection services, IConfiguration config)
        {
    #if DEBUG
            services.AddDbContext<BMSContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
    #else
            services.AddDbContext<BMSContext>(options => options.UseSqlServer(config.GetConnectionString("ReleaseConnection")));
    #endif


            return services;
        }
    }
}
