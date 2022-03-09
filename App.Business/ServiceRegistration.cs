using App.Business.Managers.Abstracts;
using App.Business.Managers.Concretes;
using App.Business.WebServiceMethods;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public static class ServiceRegistration
    {
        public static void BusinessServiceRegistration(this IServiceCollection services)
        {
            services.AddTransient<IGetApiDataService, GetApiDataService>();
            services.AddTransient<IFuelPriceOperationsManager, FuelPriceOperationsManager>();
        }
    }
}
