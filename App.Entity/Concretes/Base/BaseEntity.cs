using App.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entity.Concretes.Base
{
    public class BaseEntity : IEntity
    {
        public long Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
