using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Shop.Core.Dto.AccuWeatherDtos;
using Shop.Core.ServiceInterface;
using Shop.Models.AccuWeathers;

namespace Shop.Controllers
{
    public class AccuWeathersController : Controller
    {
        private readonly IAccuWeatherServices _accuWeatherServices;
        public AccuWeathersController (IAccuWeatherServices accuWeatherServices)
        {
            _accuWeatherServices = accuWeatherServices;

        }
        [HttpPost]
        public IActionResult SearchCity(SearchCityViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City","AccuWeathers", new { localizedName = model.LocalizedName });
            }

			// Установить сообщение об ошибке для отображения на форме
			ViewData["ErrorMessage"] = "Please fill in the search field.";

			return View(model);
        }
        [HttpGet]
        public IActionResult City(string localizedName)
        {
            AccuWeatherResultDto dto = new AccuWeatherResultDto();
            dto.LocalizedName = localizedName;

            _accuWeatherServices.AccuWeatherResult(dto);
            AccuWeatherViewModel vm = new AccuWeatherViewModel
            {

            LocalizedName = dto.LocalizedName,
			Minimum = dto.Minimum,
			Maximum = dto.Maximum,
			Link = dto.Link,

			};
            return View(vm);
        }
		public IActionResult Index()
		{
			return View();
		}
	}
}
