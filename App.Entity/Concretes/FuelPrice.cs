using App.Entity.Concretes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entity.Concretes
{
    public class FuelPrice : BaseEntity
    {
        public string Brand { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string FuelType { get; set; }
        // Some APIs send price information with commas, while others with dots. That's why it's kept as a string.
        public string Price { get; set; }
        // Some of the data coming from the API have the last update dates on their side.That's why we keep this data.
        public DateTime APILastSyncTime { get; set; }
        public bool IsLastUpdated { get; set; }
    }
}
