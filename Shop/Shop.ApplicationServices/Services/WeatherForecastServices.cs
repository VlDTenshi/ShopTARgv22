using Nancy.Json;
using Shop.Core.Dto.OpenWetaherDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ApplicationServices.Services
{
    public class WeatherForecastServices
	{
		public async Task<OpenWeatherResultDto> OpenWeatherResult(OpenWeatherResultDto dto)
		{
			string idOpenWeather = "7a1e82109b389955967ad299cc91f8ff";
			string url = $"https://api.openweathermap.org/data/2.5/weather?q={dto.City}&units=metric&appid={idOpenWeather}";

			using (WebClient client = new WebClient())
			{
				string json = client.DownloadString(url);
				OpenWeatherResponseRootDto weatherResult = new JavaScriptSerializer().Deserialize<OpenWeatherResponseRootDto>(json);

				dto.City = weatherResult.Name;
				dto.main_Temp = weatherResult.Main.main_Temp;
				dto.main_Feels_like = weatherResult.Main.main_Feels_like;
				dto.main_Humidity = weatherResult.Main.main_Humidity;
				dto.main_Pressure = weatherResult.Main.main_Pressure;
				dto.wind_Speed = weatherResult.Wind.wind_Speed;
				dto.weather_Description = weatherResult.Weathers[0].weather_Description;
			}
			return dto;
		}
	}
}
