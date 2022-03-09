using App.Dal.Repositories.Abstracts;
using App.Dal.Repositories.Concretes.Base;
using App.Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dal.Repositories.Concretes
{
    public class DistrictRepository : EntityRepositoryBase<District>, IDistrictRepository
    {
        public DistrictRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
