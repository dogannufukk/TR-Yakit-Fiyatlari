using App.Entity.Concretes.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entity.Concretes
{
    public class District : BaseEntity
    {
        public string Name { get; set; }
        public long CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
    }
}
