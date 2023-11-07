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

			}
			return dto;
		}
	}
}
