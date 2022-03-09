using App.Entity.Concretes.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entity.Concretes
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        [MaxLength(2)]
        public string PlateNumber { get; set; }
        public virtual List<District> Districts { get; set; }
    }
}
