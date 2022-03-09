using App.Dal.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dal.UnitOfWorks.MsSqlDbContext.Abstracts
{
    public interface IMsSqlUnitOfWork
    {
        ICityRepository CityRepository { get; }
        IDistrictRepository DistrictRepository { get; }
        IFuelPriceRepository FuelPriceRepository { get; }
        Task<int> SaveChangesAsync();


    }
}
