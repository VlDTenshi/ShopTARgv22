using Microsoft.AspNetCore.Mvc;
using Shop.Core.ServiceInterface;
using Shop.Models.ChuckNorris;
using Shop.Models.OpenWeathers;

namespace Shop.Controllers
{
	public class OpenChuckNorrisJokeController : Controller
	{
		private readonly IChuckNorrisServices _chuckNorrisServices;
		public OpenChuckNorrisJokeController(IChuckNorrisServices chuckNorrisServices)
		{
			_chuckNorrisServices = chuckNorrisServices;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SearchJoke(SearchChuckNorrisJoke model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Joke", "ChuckNorris");
			}
			return View(model);
		}
	}
}
