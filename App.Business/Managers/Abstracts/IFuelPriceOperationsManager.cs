using App.Business.APIResponseObjects;
using App.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App.Business.APIResponseObjects.OPETBaseResponse;

namespace App.Business.Managers.Abstracts
{
    public interface IFuelPriceOperationsManager
    {

        List<BPResponse> GetListBPFuelPriceResponseByCityName(string cityName);
        List<PETROLOFISIResponse> GetListPOFuelPriceResponse();
        List<PETROLOFISIResponse> GetListPETROLOFISIFuelPriceResponseByCityName(string cityName);
        List<PETROLOFISIResponse> GetListPETROLOFISIFuelPriceResponseByCityNameAndDistrictName(string cityName, string districtName);
        List<OPETResponse> GetListOPETFuelPriceResponseByCityPlateNumber(string cityPlateNumber);

        Task<bool> WritePETROLOFISIDataToDb(bool setLastUpdatedStatus);
        Task<bool> WriteBPDataToDb(bool setLastUpdatedStatus);
        Task<bool> WriteOPETDataToDb(bool setLastUpdatedStatus);
        Task SetLastUpdatedToFalse(string brand);

        Task<List<FuelPrice>> GetListFuelPrice(bool isLastUpdate=true,string brand="");

    }
}
