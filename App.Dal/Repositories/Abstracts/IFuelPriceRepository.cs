using App.Dal.Repositories.Abstracts.Base;
using App.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dal.Repositories.Abstracts
{
    public interface IFuelPriceRepository : IEntityRepositoryBase<FuelPrice>
    {
    }
}
