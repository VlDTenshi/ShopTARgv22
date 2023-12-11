using Nancy;
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
        //public async Task<AccuWeatherResultDto> GetCityKeyAsync(AccuWeatherResultDto dto)
        //{
        //    try { 
        //    string idOpenWeather = "giZzxuVGA97pu2AWn1x6Ira5M2073g6C";
        //    //string localizedName = "Tallinn";
        //    string url = $"http://dataservice.accuweather.com/locations/v1/cities/search?apikey={idOpenWeather}&q={dto.LocalizedName}";
        //    using (WebClient client = new WebClient())
        //    {
        //        string json = client.DownloadString(url);
        //        AccuWeatherResponseRootDto weatherResult = new JavaScriptSerializer().Deserialize<AccuWeatherResponseRootDto>(json);

        //        dto.Key = weatherResult.Key;
        //        //dto.LocalizedName = weatherResult.LocalizedName;
        //    }
        //    return dto;
        //}
        //catch (Exception ex)
        //{
        //    // Обработка ошибок, например, выброс исключения
        //    return dto;
        //}

        public async Task<AccuWeatherResultDto> AccuWeatherResult(AccuWeatherResultDto dto)
        {
            string idOpenWeather = "giZzxuVGA97pu2AWn1x6Ira5M2073g6C";

            using (WebClient client = new WebClient())
            {
                string url = $"http://dataservice.accuweather.com/locations/v1/cities/search?apikey={idOpenWeather}&q={dto.LocalizedName}";


                try
                {
                    string json = client.DownloadString(url);
                    AccuWeatherResponseRootDto weatherResult = new JavaScriptSerializer().Deserialize<List<AccuWeatherResponseRootDto>>(json).FirstOrDefault();

                    dto.Key = weatherResult.Key;

                    string forecastUrl = $"http://dataservice.accuweather.com/forecasts/v1/daily/1day/{dto.Key}?apikey={idOpenWeather}&metric=true";
                    string forecastJson = client.DownloadString(forecastUrl);
                    AccuWeatherForecastResponseRoot forecastResult = new JavaScriptSerializer().Deserialize<AccuWeatherForecastResponseRoot>(forecastJson);

                    dto.Minimum = forecastResult.DailyForecasts.FirstOrDefault().Temperature.Minimum.Value;
                    dto.Maximum = forecastResult.DailyForecasts.FirstOrDefault().Temperature.Maximum.Value;
                    dto.Link = forecastResult.DailyForecasts.FirstOrDefault().Link;

                }
                catch (WebException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return dto;
        }
    }
}
