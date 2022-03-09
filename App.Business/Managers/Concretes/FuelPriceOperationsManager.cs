using App.Business.APIResponseObjects;
using App.Business.Helper;
using App.Business.Managers.Abstracts;
using App.Business.WebServiceMethods;
using App.Dal.UnitOfWorks.MsSqlDbContext.Abstracts;
using App.Entity.Concretes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App.Business.APIResponseObjects.OPETBaseResponse;

namespace App.Business.Managers.Concretes
{
    public class FuelPriceOperationsManager : IFuelPriceOperationsManager
    {
        private readonly IMsSqlUnitOfWork unitOfWork;
        IGetApiDataService getApiDataService;
        public FuelPriceOperationsManager(IMsSqlUnitOfWork unitOfWork, IGetApiDataService getApiDataService)
        {
            this.unitOfWork = unitOfWork;
            this.getApiDataService = getApiDataService;
        }

        public string GetBPLinkByCityName(string cityName)
        {
            return "https://www.bp.com/bp-tr-pump-prices/api/PumpPrices?strCity=" + cityName;
        }
        public string GetPETROLOFISILink()
        {
            return "https://www.petrolofisi.com.tr/posvc/fiyat/guncel";
        }
        public string GetPETROLOFISILinkByCityName(string cityName)
        {
            return "https://www.petrolofisi.com.tr/posvc/fiyat/guncel?il=" + cityName;
        }
        public string GetPETROLOFISILinkByCityNameAndDistrictName(string cityName, string districtName)
        {
            return "https://www.petrolofisi.com.tr/posvc/fiyat/guncel?il=" + cityName + "&ilce=" + districtName;
        }
        public string GetOPETLinkByCityPlateNumber(string cityPlateNumber)
        {
            return "https://api.opet.com.tr/api/fuelprices/prices?ProvinceCode=" + cityPlateNumber + "&IncludeAllProducts=true";
        }

        public List<BPResponse> GetListBPFuelPriceResponseByCityName(string cityName)
        {
            List<BPResponse> priceList = null;
            var dataResult = getApiDataService.ReadWebRequest(GetBPLinkByCityName(cityName));
            if (dataResult != "error")
                priceList = JsonConvert.DeserializeObject<List<BPResponse>>(dataResult);
            return priceList;
        }
        public List<PETROLOFISIResponse> GetListPOFuelPriceResponse()
        {
            List<PETROLOFISIResponse> priceList = null;
            var dataResult = getApiDataService.ReadWebRequest(GetPETROLOFISILink());
            if (dataResult != "error")
                priceList = JsonConvert.DeserializeObject<List<PETROLOFISIResponse>>(dataResult);
            return priceList;
        }
        public List<PETROLOFISIResponse> GetListPETROLOFISIFuelPriceResponseByCityName(string cityName)
        {
            List<PETROLOFISIResponse> priceList = null;
            var dataResult = getApiDataService.ReadWebRequest(GetPETROLOFISILinkByCityName(cityName));
            if (dataResult != "error")
                priceList = JsonConvert.DeserializeObject<List<PETROLOFISIResponse>>(dataResult);
            return priceList;

        }
        public List<PETROLOFISIResponse> GetListPETROLOFISIFuelPriceResponseByCityNameAndDistrictName(string cityName, string districtName)
        {
            List<PETROLOFISIResponse> priceList = null;
            var dataResult = getApiDataService.ReadWebRequest(GetPETROLOFISILinkByCityNameAndDistrictName(cityName, districtName));
            if (dataResult != "error")
                priceList = JsonConvert.DeserializeObject<List<PETROLOFISIResponse>>(dataResult);
            return priceList;
        }
        public List<OPETResponse> GetListOPETFuelPriceResponseByCityPlateNumber(string cityPlateNumber)
        {
            List<OPETResponse> priceList = null;
            var dataResult = getApiDataService.ReadWebRequest(GetOPETLinkByCityPlateNumber(cityPlateNumber));
            if (dataResult != "error")
                priceList = JsonConvert.DeserializeObject<List<OPETResponse>>(dataResult);
            return priceList;

        }

        public async Task<bool> WritePETROLOFISIDataToDb(bool setLastUpdatedStatus)
        {
            try
            {
                string brand = "Petrol Ofisi";
                if (setLastUpdatedStatus)
                    await SetLastUpdatedToFalse(brand);
                var cityList = await unitOfWork.CityRepository.GetAllAsync();
                var districtList = await unitOfWork.DistrictRepository.GetAllAsync();

                var fuelPriceList = new List<FuelPrice>();
                for (int i = 0; i < cityList.Count; i++)
                {
                    cityList[i].Name = AlphabeticHelper.ConvertCharToEnglishAlphabeticalCharacter(cityList[i].Name);
                    if (cityList[i].Name == "AFYONKARAHİSAR" || cityList[i].Name == "AFYONKARAHISAR" || cityList[i].Name == "Afyonkarahisar")
                        cityList[i].Name = "AFYON";
                    Console.WriteLine(DateTime.Now + ": Petrol Ofisi -> " + cityList[i].Name + " şehir verisi çekilmeye başlandı.");
                    var priceData = GetListPETROLOFISIFuelPriceResponseByCityName(cityList[i].Name);
                    Console.WriteLine(DateTime.Now + ": Petrol Ofisi -> " + cityList[i].Name + " şehri verisi başarılı şekilde alındı.");

                    for (int t = 0; t < priceData.Count; t++)
                    {
                        #region K95 Price
                        var k95Price = new FuelPrice();
                        k95Price.APILastSyncTime = priceData[t].AktarimTarihi;
                        k95Price.Brand = brand;
                        k95Price.City = priceData[t].Il;
                        k95Price.District = priceData[t].Ilce;
                        k95Price.Price = priceData[t].K95;
                        k95Price.IsLastUpdated = true;
                        k95Price.CreatedTime = DateTime.Now;
                        k95Price.FuelType = "K95";
                        fuelPriceList.Add(k95Price);
                        #endregion
                        #region K97 Price
                        var k97Price = new FuelPrice();
                        k97Price.APILastSyncTime = priceData[t].AktarimTarihi;
                        k97Price.Brand = brand;
                        k97Price.City = priceData[t].Il;
                        k97Price.District = priceData[t].Ilce;
                        k97Price.Price = priceData[t].K97;
                        k97Price.IsLastUpdated = true;
                        k97Price.CreatedTime = DateTime.Now;
                        k97Price.FuelType = "K97";
                        fuelPriceList.Add(k97Price);
                        #endregion
                        #region Mot50 Price
                        var mot50Price = new FuelPrice();
                        mot50Price.APILastSyncTime = priceData[t].AktarimTarihi;
                        mot50Price.Brand = brand;
                        mot50Price.City = priceData[t].Il;
                        mot50Price.District = priceData[t].Ilce;
                        mot50Price.Price = priceData[t].Mot50;
                        mot50Price.IsLastUpdated = true;
                        mot50Price.CreatedTime = DateTime.Now;
                        mot50Price.FuelType = "Mot50";
                        fuelPriceList.Add(mot50Price);
                        #endregion
                        #region MotPro Price
                        var motProPrice = new FuelPrice();
                        motProPrice.APILastSyncTime = priceData[t].AktarimTarihi;
                        motProPrice.Brand = brand;
                        motProPrice.City = priceData[t].Il;
                        motProPrice.District = priceData[t].Ilce;
                        motProPrice.Price = priceData[t].MotPro;
                        motProPrice.IsLastUpdated = true;
                        motProPrice.CreatedTime = DateTime.Now;
                        motProPrice.FuelType = "MotPro";
                        fuelPriceList.Add(motProPrice);
                        #endregion
                        #region PoGaz Price
                        var poGazPrice = new FuelPrice();
                        poGazPrice.APILastSyncTime = priceData[t].AktarimTarihi;
                        poGazPrice.Brand = brand;
                        poGazPrice.City = priceData[t].Il;
                        poGazPrice.District = priceData[t].Ilce;
                        poGazPrice.Price = priceData[t].PoGaz;
                        poGazPrice.IsLastUpdated = true;
                        poGazPrice.CreatedTime = DateTime.Now;
                        poGazPrice.FuelType = "PO Gaz";
                        fuelPriceList.Add(poGazPrice);
                        #endregion
                    }

                }
                await unitOfWork.FuelPriceRepository.AddRangeAsync(fuelPriceList);
                await unitOfWork.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                //TODO: Exception log
                return false;
            }
        }

        public async Task<bool> WriteBPDataToDb(bool setLastUpdatedStatus)
        {
            try
            {
                string brand = "BP";
                if (setLastUpdatedStatus)
                    await SetLastUpdatedToFalse(brand);

                var cityList = await unitOfWork.CityRepository.GetAllAsync();
                var districtList = await unitOfWork.DistrictRepository.GetAllAsync();

                var fuelPriceList = new List<FuelPrice>();
                for (int i = 0; i < cityList.Count; i++)
                {


                    // Specific status: API not contains that values. For api;
                    // İstanbul => İSTANBUL (ANADOLU) and İSTANBUL (AVRUPA)
                    if (cityList[i].Name == "ISTANBUL" || cityList[i].Name == "İSTANBUL") continue;
                    if (cityList[i].Name == "KOCAELİ (İZMİT)")
                        cityList[i].Name = "KOCAELİ";
                    if (cityList[i].Name == "SAKARYA (ADAPAZARI)")
                        cityList[i].Name = "SAKARYA";
                    if (cityList[i].Name == "AFYON") cityList[i].Name = "AFYONKARAHİSAR";

                    cityList[i].Name = AlphabeticHelper.ConvertCharToEnglishAlphabeticalCharacter(cityList[i].Name);
                    Console.WriteLine(DateTime.Now + ": BP -> " + cityList[i].Name + " şehir verisi çekilmeye başlandı.");
                    var priceData = GetListBPFuelPriceResponseByCityName(cityList[i].Name);
                    Console.WriteLine(DateTime.Now + ": BP -> " + cityList[i].Name + " şehri verisi başarılı şekilde alındı.");


                    for (int t = 0; t < priceData.Count; t++)
                    {
                        #region Benzin Price
                        var benzinPrice = new FuelPrice();
                        benzinPrice.APILastSyncTime = priceData[t]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                        benzinPrice.Brand = brand;
                        benzinPrice.City = priceData[t]?.City ?? "";
                        benzinPrice.District = priceData[t]?.District ?? "";
                        benzinPrice.Price = priceData[t]?.Benzin ?? "";
                        benzinPrice.IsLastUpdated = true;
                        benzinPrice.CreatedTime = DateTime.Now;
                        benzinPrice.FuelType = "Benzin";
                        fuelPriceList.Add(benzinPrice);
                        #endregion
                        #region Benzin Ultimate Price
                        var benzinUltimatePrice = new FuelPrice();
                        benzinUltimatePrice.APILastSyncTime = priceData[t]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                        benzinUltimatePrice.Brand = brand;
                        benzinUltimatePrice.City = priceData[t]?.City ?? "";
                        benzinUltimatePrice.District = priceData[t]?.District ?? "";
                        benzinUltimatePrice.Price = priceData[t]?.BenzinUltimate ?? "";
                        benzinUltimatePrice.IsLastUpdated = true;
                        benzinUltimatePrice.CreatedTime = DateTime.Now;
                        benzinUltimatePrice.FuelType = "Benzin Ultimate";
                        fuelPriceList.Add(benzinUltimatePrice);
                        #endregion
                        #region MotorinUltimate Price
                        var motorinUltimatePrice = new FuelPrice();
                        motorinUltimatePrice.APILastSyncTime = priceData[t]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                        motorinUltimatePrice.Brand = brand;
                        motorinUltimatePrice.City = priceData[t]?.City ?? "";
                        motorinUltimatePrice.District = priceData[t]?.District ?? "";
                        motorinUltimatePrice.Price = priceData[t]?.MotorinUltimate ?? "";
                        motorinUltimatePrice.IsLastUpdated = true;
                        motorinUltimatePrice.CreatedTime = DateTime.Now;
                        motorinUltimatePrice.FuelType = "Motorin Ultimate";
                        fuelPriceList.Add(motorinUltimatePrice);
                        #endregion
                        #region Motorin Price
                        var motorinPrice = new FuelPrice();
                        motorinPrice.APILastSyncTime = priceData[t]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                        motorinPrice.Brand = brand;
                        motorinPrice.City = priceData[t]?.City ?? "";
                        motorinPrice.District = priceData[t]?.District ?? "";
                        motorinPrice.Price = priceData[t]?.Motorin ?? "";
                        motorinPrice.IsLastUpdated = true;
                        motorinPrice.CreatedTime = DateTime.Now;
                        motorinPrice.FuelType = "Motorin";
                        fuelPriceList.Add(motorinPrice);

                        #endregion

                        #region Lpg Price
                        var lpgPrice = new FuelPrice();
                        lpgPrice.APILastSyncTime = priceData[t]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                        lpgPrice.Brand = brand;
                        lpgPrice.City = priceData[t]?.City ?? "";
                        lpgPrice.District = priceData[t]?.District ?? "";
                        lpgPrice.Price = priceData[t]?.LpgPrice ?? "";
                        lpgPrice.IsLastUpdated = true;
                        lpgPrice.CreatedTime = DateTime.Now;
                        lpgPrice.FuelType = "LPG";
                        fuelPriceList.Add(lpgPrice);

                        #endregion

                    }

                }
                var istanbulAvrupaPriceData = GetListBPFuelPriceResponseByCityName("İSTANBUL (AVRUPA)");
                for (int i = 0; i < istanbulAvrupaPriceData.Count; i++)
                {
                    #region Benzin Price
                    var benzinPrice = new FuelPrice();
                    benzinPrice.APILastSyncTime = istanbulAvrupaPriceData[i]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                    benzinPrice.Brand = brand;
                    benzinPrice.City = istanbulAvrupaPriceData[i].City;
                    benzinPrice.District = istanbulAvrupaPriceData[i].District;
                    benzinPrice.Price = istanbulAvrupaPriceData[i].Benzin;
                    benzinPrice.IsLastUpdated = true;
                    benzinPrice.CreatedTime = DateTime.Now;
                    benzinPrice.FuelType = "Benzin";
                    fuelPriceList.Add(benzinPrice);
                    #endregion
                    #region Benzin Ultimate Price
                    var benzinUltimatePrice = new FuelPrice();
                    benzinUltimatePrice.APILastSyncTime = istanbulAvrupaPriceData[i]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                    benzinUltimatePrice.Brand = brand;
                    benzinUltimatePrice.City = istanbulAvrupaPriceData[i]?.City ?? "";
                    benzinUltimatePrice.District = istanbulAvrupaPriceData[i]?.District ?? "";
                    benzinUltimatePrice.Price = istanbulAvrupaPriceData[i]?.BenzinUltimate ?? "";
                    benzinUltimatePrice.IsLastUpdated = true;
                    benzinUltimatePrice.CreatedTime = DateTime.Now;
                    benzinUltimatePrice.FuelType = "Benzin Ultimate";
                    fuelPriceList.Add(benzinUltimatePrice);
                    #endregion
                    #region MotorinUltimate Price
                    var motorinUltimatePrice = new FuelPrice();
                    motorinUltimatePrice.APILastSyncTime = istanbulAvrupaPriceData[i]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                    motorinUltimatePrice.Brand = brand;
                    motorinUltimatePrice.City = istanbulAvrupaPriceData[i]?.City ?? "";
                    motorinUltimatePrice.District = istanbulAvrupaPriceData[i]?.District ?? "";
                    motorinUltimatePrice.Price = istanbulAvrupaPriceData[i]?.MotorinUltimate ?? "";
                    motorinUltimatePrice.IsLastUpdated = true;
                    motorinUltimatePrice.CreatedTime = DateTime.Now;
                    motorinUltimatePrice.FuelType = "Motorin Ultimate";
                    fuelPriceList.Add(motorinUltimatePrice);
                    #endregion
                    #region Motorin Price
                    var motorinPrice = new FuelPrice();
                    motorinPrice.APILastSyncTime = istanbulAvrupaPriceData[i]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                    motorinPrice.Brand = brand;
                    motorinPrice.City = istanbulAvrupaPriceData[i]?.City ?? "";
                    motorinPrice.District = istanbulAvrupaPriceData[i]?.District ?? "";
                    motorinPrice.Price = istanbulAvrupaPriceData[i]?.Motorin ?? "";
                    motorinPrice.IsLastUpdated = true;
                    motorinPrice.CreatedTime = DateTime.Now;
                    motorinPrice.FuelType = "Motorin";
                    fuelPriceList.Add(motorinPrice);

                    #endregion

                    #region Lpg Price
                    var lpgPrice = new FuelPrice();
                    lpgPrice.APILastSyncTime = istanbulAvrupaPriceData[i]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                    lpgPrice.Brand = brand;
                    lpgPrice.City = istanbulAvrupaPriceData[i]?.City ?? "";
                    lpgPrice.District = istanbulAvrupaPriceData[i]?.District ?? "";
                    lpgPrice.Price = istanbulAvrupaPriceData[i]?.LpgPrice ?? "";
                    lpgPrice.IsLastUpdated = true;
                    lpgPrice.CreatedTime = DateTime.Now;
                    lpgPrice.FuelType = "LPG";
                    fuelPriceList.Add(lpgPrice);

                    #endregion
                }

                var istanbulAnadoluPriceData = GetListBPFuelPriceResponseByCityName("İSTANBUL (ANADOLU)");
                for (int i = 0; i < istanbulAnadoluPriceData.Count; i++)
                {

                    #region Benzin Price
                    var benzinPrice = new FuelPrice();
                    benzinPrice.APILastSyncTime = istanbulAnadoluPriceData[i]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                    benzinPrice.Brand = brand;
                    benzinPrice.City = istanbulAvrupaPriceData[i]?.City ?? "";
                    benzinPrice.District = istanbulAvrupaPriceData[i]?.District ?? "";
                    benzinPrice.Price = istanbulAvrupaPriceData[i]?.Benzin ?? "";
                    benzinPrice.IsLastUpdated = true;
                    benzinPrice.CreatedTime = DateTime.Now;
                    benzinPrice.FuelType = "Benzin";
                    fuelPriceList.Add(benzinPrice);
                    #endregion
                    #region Benzin Ultimate Price
                    var benzinUltimatePrice = new FuelPrice();
                    benzinUltimatePrice.APILastSyncTime = istanbulAnadoluPriceData[i]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                    benzinUltimatePrice.Brand = brand;
                    benzinUltimatePrice.City = istanbulAvrupaPriceData[i]?.City ?? "";
                    benzinUltimatePrice.District = istanbulAvrupaPriceData[i]?.District ?? "";
                    benzinUltimatePrice.Price = istanbulAvrupaPriceData[i]?.BenzinUltimate ?? "";
                    benzinUltimatePrice.IsLastUpdated = true;
                    benzinUltimatePrice.CreatedTime = DateTime.Now;
                    benzinUltimatePrice.FuelType = "Benzin Ultimate";
                    fuelPriceList.Add(benzinUltimatePrice);
                    #endregion
                    #region MotorinUltimate Price
                    var motorinUltimatePrice = new FuelPrice();
                    motorinUltimatePrice.APILastSyncTime = istanbulAnadoluPriceData[i]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                    motorinUltimatePrice.Brand = brand;
                    motorinUltimatePrice.City = istanbulAvrupaPriceData[i]?.City ?? "";
                    motorinUltimatePrice.District = istanbulAvrupaPriceData[i]?.District ?? "";
                    motorinUltimatePrice.Price = istanbulAvrupaPriceData[i]?.MotorinUltimate ?? "";
                    motorinUltimatePrice.IsLastUpdated = true;
                    motorinUltimatePrice.CreatedTime = DateTime.Now;
                    motorinUltimatePrice.FuelType = "Motorin Ultimate";
                    fuelPriceList.Add(motorinUltimatePrice);
                    #endregion
                    #region Motorin Price
                    var motorinPrice = new FuelPrice();
                    motorinPrice.APILastSyncTime = istanbulAnadoluPriceData[i]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                    motorinPrice.Brand = brand;
                    motorinPrice.City = istanbulAvrupaPriceData[i]?.City ?? "";
                    motorinPrice.District = istanbulAvrupaPriceData[i]?.District ?? "";
                    motorinPrice.Price = istanbulAvrupaPriceData[i]?.Motorin ?? "";
                    motorinPrice.IsLastUpdated = true;
                    motorinPrice.CreatedTime = DateTime.Now;
                    motorinPrice.FuelType = "Motorin";
                    fuelPriceList.Add(motorinPrice);

                    #endregion

                    #region Lpg Price
                    var lpgPrice = new FuelPrice();
                    lpgPrice.APILastSyncTime = istanbulAnadoluPriceData[i]?.DtPriceListDate ?? DateTime.Now; // API not have last integrated time
                    lpgPrice.Brand = brand;
                    lpgPrice.City = istanbulAvrupaPriceData[i]?.City ?? "";
                    lpgPrice.District = istanbulAvrupaPriceData[i]?.District ?? "";
                    lpgPrice.Price = istanbulAvrupaPriceData[i]?.LpgPrice ?? "";
                    lpgPrice.IsLastUpdated = true;
                    lpgPrice.CreatedTime = DateTime.Now;
                    lpgPrice.FuelType = "LPG";
                    fuelPriceList.Add(lpgPrice);

                    #endregion
                }

                await unitOfWork.FuelPriceRepository.AddRangeAsync(fuelPriceList);
                await unitOfWork.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                //TODO: Exception log
                return false;
            }
        }

        public async Task<bool> WriteOPETDataToDb(bool setLastUpdatedStatus)
        {
            try
            {
                string brand = "Opet";
                if (setLastUpdatedStatus)
                    await SetLastUpdatedToFalse(brand);
                var cityList = await unitOfWork.CityRepository.GetAllAsync();
                var districtList = await unitOfWork.DistrictRepository.GetAllAsync();

                var fuelPriceList = new List<FuelPrice>();
                for (int i = 0; i < cityList.Count; i++)
                {
                    cityList[i].Name = AlphabeticHelper.ConvertCharToEnglishAlphabeticalCharacter(cityList[i].Name);
                    Console.WriteLine(DateTime.Now + ": Opet -> " + cityList[i].Name + " şehir verisi çekilmeye başlandı.");
                    var priceData = GetListOPETFuelPriceResponseByCityPlateNumber(cityList[i].PlateNumber);
                    Console.WriteLine(DateTime.Now + ": Opet -> " + cityList[i].Name + " şehri verisi başarılı şekilde alındı.");

                    for (int t = 0; t < priceData.Count; t++)
                    {
                        #region Kurşunsuz Benzin Price
                        var kursunsuzBenzinPrice = new FuelPrice();
                        kursunsuzBenzinPrice.APILastSyncTime = DateTime.Now; // API not have last integrated time
                        kursunsuzBenzinPrice.Brand = brand;
                        kursunsuzBenzinPrice.City = priceData[t].ProvinceName;
                        kursunsuzBenzinPrice.District = priceData[t].DistrictName;
                        kursunsuzBenzinPrice.Price = priceData[t].Prices[0].Amount.ToString();
                        kursunsuzBenzinPrice.IsLastUpdated = true;
                        kursunsuzBenzinPrice.CreatedTime = DateTime.Now;
                        kursunsuzBenzinPrice.FuelType = "Kurşunsuz Benzin 95"; //prices[0]
                        fuelPriceList.Add(kursunsuzBenzinPrice);
                        #endregion
                        #region Motorin UltraForce Price
                        var motorinUltraForcePrice = new FuelPrice();
                        motorinUltraForcePrice.APILastSyncTime = DateTime.Now; // API not have last integrated time
                        motorinUltraForcePrice.Brand = brand;
                        motorinUltraForcePrice.City = priceData[t].ProvinceName;
                        motorinUltraForcePrice.District = priceData[t].DistrictName;
                        motorinUltraForcePrice.Price = priceData[t].Prices[1].Amount.ToString();
                        motorinUltraForcePrice.IsLastUpdated = true;
                        motorinUltraForcePrice.CreatedTime = DateTime.Now;
                        motorinUltraForcePrice.FuelType = "Motorin Ultraforce"; //prices[0]
                        fuelPriceList.Add(motorinUltraForcePrice);
                        #endregion
                        #region Mot50 Price
                        var motorinEcoForce = new FuelPrice();
                        motorinEcoForce.APILastSyncTime = DateTime.Now; // API not have last integrated time
                        motorinEcoForce.Brand = brand;
                        motorinEcoForce.City = priceData[t].ProvinceName;
                        motorinEcoForce.District = priceData[t].DistrictName;
                        motorinEcoForce.Price = priceData[t].Prices[2].Amount.ToString();
                        motorinEcoForce.IsLastUpdated = true;
                        motorinEcoForce.CreatedTime = DateTime.Now;
                        motorinEcoForce.FuelType = "Motorin Ecoforce"; //prices[0]
                        fuelPriceList.Add(motorinEcoForce);
                        #endregion

                    }

                }
                var k = fuelPriceList;
                await unitOfWork.FuelPriceRepository.AddRangeAsync(fuelPriceList);
                await unitOfWork.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                //TODO: Exception log
                return false;
            }
        }

        /// <summary>
        /// It was created to indicate the records that are up-to-date after synchronization.
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public async Task SetLastUpdatedToFalse(string brand)
        {
            var brandLastUpdatedList = await unitOfWork.FuelPriceRepository.GetAllAsync(x => x.IsLastUpdated && x.Brand == brand);
            foreach (var item in brandLastUpdatedList)
            {
                item.IsLastUpdated = false;
                unitOfWork.FuelPriceRepository.Update(item);
            }

        }

        public async Task<List<FuelPrice>> GetListFuelPrice(bool isLastUpdate = true, string brand = "")
        {
            var fuelPriceDataList = new List<FuelPrice>();
            if (isLastUpdate)
                fuelPriceDataList = await unitOfWork.FuelPriceRepository.GetAllAsync(x => x.IsLastUpdated);
            else
                fuelPriceDataList = await unitOfWork.FuelPriceRepository.GetAllAsync(x => !x.IsLastUpdated);

            // When pulling this data, server-side operations need to be done.
            // This field is running inefficiently. It will be improved.
            if (!String.IsNullOrEmpty(brand))
            {
                brand = AlphabeticHelper.ConvertCharToEnglishAlphabeticalCharacter(brand);
                fuelPriceDataList = fuelPriceDataList.Where(x => x.Brand.Contains(brand)).ToList();
            }
            return fuelPriceDataList;
        }
    }
}
