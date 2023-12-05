using Nancy.Json;
using Shop.Core.Dto.AccuWeatherDtos;
using Shop.Core.Dto.OpenWetaherDtos;
using Shop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ApplicationServices.Services
{
    public class AccuWeatherServices : IAccuWeatherServices
    {
        public async Task<AccuWeatherResultDto> GetCityKeyAsync(AccuWeatherResultDto dto)
        {
            try { 
            string idOpenWeather = "giZzxuVGA97pu2AWn1x6Ira5M2073g6C";
            //string localizedName = "Tallinn";
            string url = $"http://dataservice.accuweather.com/locations/v1/cities/search?apikey={idOpenWeather}&q={dto.LocalizedName}";
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                AccuWeatherResponseRootDto weatherResult = new JavaScriptSerializer().Deserialize<AccuWeatherResponseRootDto>(json);

                dto.Key = weatherResult.Key;
                //dto.LocalizedName = weatherResult.LocalizedName;
            }
            return dto;
        }
        catch (Exception ex)
        {
            // Обработка ошибок, например, выброс исключения
            return dto;
        }
}
        public async Task<AccuWeatherResultDto> AccuWeatherResult(AccuWeatherResultDto dto)
        {
            try
            {
                if (!string.IsNullOrEmpty(dto.Key))
                {

                    string idOpenWeather = "giZzxuVGA97pu2AWn1x6Ira5M2073g6C";
                    string url = $"http://dataservice.accuweather.com/forecasts/v1/daily/1day/{dto.Key}?apikey={idOpenWeather}&metric=true";
                    using (WebClient client = new WebClient())
                    {
                        string json = client.DownloadString(url);
                        AccuWeatherResponseRootDto weatherResult = new JavaScriptSerializer().Deserialize<AccuWeatherResponseRootDto>(json);

                        //dto.Key = weatherResult.Key;
                        dto.LocalizedName = weatherResult.LocalizedName;
                        dto.Date = weatherResult.Date;
                        dto.Value = weatherResult.Value;
                        dto._Value = weatherResult.Value1;
                        dto.EpochDate = weatherResult.EpochDate;           
                    }
                }
                return dto;
                }
            catch (Exception ex)
                {
                    // Обработка ошибок, например, выброс исключения
                    return dto;
                }
        }
    }
}
