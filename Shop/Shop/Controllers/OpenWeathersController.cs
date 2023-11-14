using Microsoft.AspNetCore.Mvc;
using Shop.Core.Dto.OpenWetaherDtos;
using Shop.Core.ServiceInterface;
using Shop.Models.OpenWeathers;

namespace Shop.Controllers
{
	public class OpenWeathersController : Controller
	{
		private readonly IWeatherForecastServices _weatherForecastServices;

		public OpenWeathersController
			(
				IWeatherForecastServices weatherForecastServices
			)
		{
			_weatherForecastServices = weatherForecastServices;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SearchCity(SearchCityViewModel model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("City", "OpenWeathers", new { city = model.CityName });
			}
			return View(model);
		}
		[HttpGet]
		public IActionResult City(string city) 
		{
			OpenWeatherResultDto dto = new();
			dto.City = city;

			_weatherForecastServices.OpenWeatherResult(dto);
			OpenWeatherViewModel vm = new();

			vm.City = dto.City;
			vm.Lon = dto.Lon;
			vm.Lat = dto.Lat;
			vm.weather_Id = dto.weather_Id;
			vm.weather_Main = dto.weather_Main;
			vm.weather_Description = dto.weather_Description;
			vm.weather_Icon = dto.weather_Icon;
			vm.Base = dto.Base;
			vm.main_Temp = dto.main_Temp;
			vm.main_Feels_like = dto.main_Feels_like;
			vm.main_Temp_max = dto.main_Temp_max;
			vm.main_Temp_min = dto.main_Temp_min;
			vm.main_Pressure = dto.main_Pressure;
			vm.main_Humidity = dto.main_Humidity;
			vm.main_Sea_level = dto.main_Sea_level;
			vm.main_Grnd_level = dto.main_Grnd_level;
			vm.Visibility = dto.Visibility;
			vm.wind_Speed = dto.wind_Speed;
			vm.wind_Deg = dto.wind_Deg;
			vm.wind_Gust = dto.wind_Gust;
			vm.rain_1h = dto.rain_1h;
			vm.clouds_All = dto.clouds_All;
			vm.s_1h = dto.s_1h;
			vm.s_3h = dto.s_3h;
			vm.Dt = dto.Dt;
			vm.sys_Type = dto.sys_Type;
			vm.sys_Id = dto.sys_Id;
			vm.sys_Country = dto.sys_Country;
			vm.sys_sunrise = dto.sys_sunrise;
			vm.sys_sunset = dto.sys_sunset;
			vm.Timezone = dto.Timezone;
			vm.main_Id = dto.main_Id;
			vm.Name = dto.Name;
			vm.Cod = dto.Cod;

			return View(vm);
		}
	}
}
