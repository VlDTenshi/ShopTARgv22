using Nancy.Json;
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
    public class WeatherForecastServices : IWeatherForecastServices
	{
		public async Task<OpenWeatherResultDto> OpenWeatherResult(OpenWeatherResultDto dto)
		{
			string idOpenWeather = "1b7d0b430317d9c04f417987a5935115";
			string url = $"https://api.openweathermap.org/data/2.5/weather?q={dto.City}&units=metric&appid={idOpenWeather}";

			using (WebClient client = new WebClient())
			{
				string json = client.DownloadString(url);
				OpenWeatherResponseRootDto weatherResult = new JavaScriptSerializer().Deserialize<OpenWeatherResponseRootDto>(json);

				dto.City = weatherResult.Name;
				dto.main_Temp = weatherResult.Main.Temp;
				dto.main_Feels_like = weatherResult.Main.Feels_like;
				dto.main_Humidity = weatherResult.Main.Humidity;
				dto.main_Pressure = weatherResult.Main.Pressure;
				dto.wind_Speed = weatherResult.Wind.Speed;
				dto.weather_Description = weatherResult.Weather[0].Description;
			}
			return dto;
		}
	}
}
