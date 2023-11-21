using Microsoft.AspNetCore.Mvc;
using Shop.Core.Dto.Chuck;
using Shop.Core.ServiceInterface;
using Shop.Models.ChuckNorris;
using Shop.Models.OpenWeathers;

namespace Shop.Controllers
{
	public class ChuckNorrisJokeController : Controller
	{
		private readonly IChuckNorrisServices _chuckNorrisServices;
		public ChuckNorrisJokeController(IChuckNorrisServices chuckNorrisServices)
		{
			_chuckNorrisServices = chuckNorrisServices;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SearchJoke(ChuckNorrisViewModel model)
		{
			return RedirectToAction("Joke", "ChuckNorris");
		}
		[HttpGet]
		public IActionResult Joke()
		{
			ChuckNorrisResultDto dto = new();

			_chuckNorrisServices.ChuckNorrisResult(dto);
			ChuckNorrisViewModel vm = new();

			//vm.Categories = dto.Categories;
			vm.Created_at = dto.Created_at;
			vm.Icon_url = dto.Icon_url;
			vm.Id = dto.Id;
			vm.Updated_at = dto.Updated_at;
			vm.Url = dto.Url;
			vm.Value = dto.Value;

			return View(vm);
		}
	}
}
