using App.Dal.Contexts;
using App.Dal.Repositories.Abstracts;
using App.Dal.Repositories.Concretes;
using App.Dal.UnitOfWorks.MsSqlDbContext.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dal.UnitOfWorks.MsSqlDbContext.Concretes
{
    public class MsSqlUnitOfWork : IMsSqlUnitOfWork
    {
        private DbContext dbContext;
        public ICityRepository CityRepository { get; private set; }

        public IDistrictRepository DistrictRepository { get; private set; }

        public IFuelPriceRepository FuelPriceRepository { get; private set; }



        public MsSqlUnitOfWork(ContextMsSqlDb context)
        {
            dbContext = context;
            CityRepository = new CityRepository(context);
            DistrictRepository = new DistrictRepository(context);
            FuelPriceRepository = new FuelPriceRepository(context);
        }
        public async Task<int> SaveChangesAsync()
        {
            return await dbContext.SaveChangesAsync();

        }

    }
}
