using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            return View();
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
            AccuWeatherResultDto dto = new();
            dto.LocalizedName = localizedName;

            _accuWeatherServices.AccuWeatherResult(dto);
            AccuWeatherViewModel vm = new();

            vm.LocalizedName = dto.LocalizedName;
            vm.Date = dto.Date;
            vm.Value = dto.Value;
            vm._Value = dto._Value;
            vm.EpochDate = dto.EpochDate;

            return View(vm);
        }
    }
}
