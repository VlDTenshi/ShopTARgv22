using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Shop.Controllers
{
	public class ChatHubController : Controller
	{
		private readonly ILogger<ChatHubController> _logger;

		public ChatHubController(ILogger<ChatHubController> logger)
		{
			_logger = logger;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Privacy()
		{
			return View();
		}
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
