using App.Business.Managers.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.API.Controllers
{
    [Route("api/fuelprice")]
    [ApiController]
    public class FuelPriceController : ControllerBase
    {
        private readonly IFuelPriceOperationsManager fuelPriceOperationsManager;

        public FuelPriceController(IFuelPriceOperationsManager fuelPriceOperationsManager)
        {
            this.fuelPriceOperationsManager = fuelPriceOperationsManager;
        }
        [HttpGet("update")]
        public async Task<IActionResult> UpdatePrice()
        {
            var startTime = DateTime.Now;
            await fuelPriceOperationsManager.WriteBPDataToDb(true);
            await fuelPriceOperationsManager.WritePETROLOFISIDataToDb(true);
            await fuelPriceOperationsManager.WriteOPETDataToDb(true);
            var endTime = DateTime.Now;
            return Ok("Başlangıç: " + startTime + " --- Bitiş: " + endTime);
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetListFuelPriceData(bool isLastUpdate, string brand)
        {
            return Ok(await fuelPriceOperationsManager.GetListFuelPrice(isLastUpdate,brand));
        }
    }
}
