using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.APIResponseObjects
{
    public class BPResponse
    {
        public DateTime DtPriceListDate { get; set; }
        public string District { get; set; } = "";
        public string City { get; set; } = "";
        public string Benzin { get; set; } = "";
        public string GazYagi { get; set; } = "";
        public string BenzinUltimate { get; set; } = "";
        public string MotorinUltimate { get; set; } = "";
        public string Motorin { get; set; } = "";
        public string FuelOil { get; set; } = "";
        public string KaloriferYakiti { get; set; } = "";
        public string FuelOilYuksekKukurt { get; set; } = "";
        public string LpgPrice { get; set; } = "";
    }
}
