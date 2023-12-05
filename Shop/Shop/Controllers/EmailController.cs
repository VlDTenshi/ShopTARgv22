using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Dto.EmailDtos;
using Shop.Core.ServiceInterface;
using Shop.Models.Emails;

namespace Shop.Controllers
{
	public class EmailsController : Controller
	{
		private readonly IEmailService _emailServices;

		public EmailsController
			(IEmailService emailServices)
		{
			_emailServices = emailServices;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SendEmail(EmailViewModel vm)
		{
			var dto = new EmailDto()
			{

				To = vm.To,
				Subject = vm.Subject,
				Body = vm.Body,
			};

			_emailServices.SendEmail(dto);
			//return RedirectToAction(nameof(Index));
			return View("SendEmail", vm);

		}


	}
}
