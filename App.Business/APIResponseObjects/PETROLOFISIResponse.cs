using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.APIResponseObjects
{
    public class PETROLOFISIResponse
    {
        public DateTime AktarimTarihi { get; set; }
        public string K95 { get; set; }
        public string K97 { get; set; }
        public string Mot50 { get; set; }
        public string MotPro { get; set; }
        public string PoGaz { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
    }
}
