using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.APIResponseObjects
{
    public class OPETBaseResponse
    {
        public class Price
        {
            public string Id { get; set; }
            public string ProductName { get; set; }
            public string ProductShortName { get; set; }
            public double Amount { get; set; }
            public string ProductCode { get; set; }
        }

        public class OPETResponse
        {
            public int ProvinceCode { get; set; }
            public string ProvinceName { get; set; }
            public string DistrictCode { get; set; }
            public string DistrictName { get; set; }
            public List<Price> Prices { get; set; }
        }
    }
}
