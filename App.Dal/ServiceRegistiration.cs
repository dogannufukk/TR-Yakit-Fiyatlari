using App.Dal.UnitOfWorks.MsSqlDbContext.Abstracts;
using App.Dal.UnitOfWorks.MsSqlDbContext.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dal
{
    public static class ServiceRegistiration
    {
        public static void DalServiceRegistiration(this IServiceCollection services)
        {
            services.AddTransient<IMsSqlUnitOfWork, MsSqlUnitOfWork>();
        }
    }
}
