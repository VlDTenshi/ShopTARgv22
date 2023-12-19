using Microsoft.AspNetCore.Mvc;
using Shop.Core.Dto.CoctailDtos;
using Shop.Core.ServiceInterface;
using Shop.Models.Coctails;

namespace Shop.Controllers
{
	public class CoctailsController : Controller
	{
		private readonly ICoctailServices _coctailServices;

		public CoctailsController(ICoctailServices coctailServices)
		{
			_coctailServices = coctailServices;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SearchDrink(SearchCoctailViewModel model) 
		{
			if(ModelState.IsValid)
			{
				return RedirectToAction("Drink","Coctails", new {drink = model.strDrink});
			}

            // Установить сообщение об ошибке для отображения на форме
            ViewData["ErrorMessage"] = "Please fill in the search field.";

            return View(model);
		}
		[HttpGet]
		public IActionResult Drink(string drink) 
		{
			CoctailResultDto dto = new();
			dto.strDrink = drink;
			
			_coctailServices.CoctailResult(dto);
			CoctailViewModel vm = new();

			vm.idDrink = dto.idDrink;
			vm.Drink = dto.strDrink;
			vm.DrinkAlternate = dto.strDrinkAlternate;
			vm.Tags = dto.strTags;
			vm.Video = dto.strVideo;
			vm.Category = dto.strCategory;
			vm.IBA = dto.strIBA;
			vm.Alcoholic = dto.strAlcoholic;
			vm.Glass = dto.strGlass;
			vm.Instructions = dto.strInstructions;
			vm.InstructionsES = dto.strInstructionsES;
			vm.InstructionsDE = dto.strInstructionsDE;
			vm.InstructionsFR = dto.strInstructionsFR;
			vm.InstructionsIT = dto.strInstructionsIT;
			vm.InstructionsZHHANS = dto.strInstructionsZHHANS;
			vm.InstructionsZHHANT = dto.strInstructionsZHHANT;
			vm.DrinkThumb = dto.strDrinkThumb;
			vm.Ingredient1 = dto.strIngredient1;
			vm.Ingredient2 = dto.strIngredient2;
			vm.Ingredient3 = dto.strIngredient3;
			vm.Ingredient4 = dto.strIngredient4;
			vm.Ingredient5 = dto.strIngredient5;
			vm.Ingredient6 = dto.strIngredient6;
			vm.Ingredient7 = dto.strIngredient7;
			vm.Ingredient8 = dto.strIngredient8;
			vm.Ingredient9 = dto.strIngredient9;
			vm.Ingredient10 = dto.strIngredient10;
			vm.Ingredient11 = dto.strIngredient11;
			vm.Ingredient12 = dto.strIngredient12;
			vm.Ingredient13 = dto.strIngredient13;
			vm.Ingredient14 = dto.strIngredient14;
			vm.Ingredient15 = dto.strIngredient15;
			vm.Measure1 = dto.strMeasure1;
			vm.Measure2 = dto.strMeasure2;
			vm.Measure3 = dto.strMeasure3;
			vm.Measure4 = dto.strMeasure4;
			vm.Measure5 = dto.strMeasure5;
			vm.Measure6 = dto.strMeasure6;
			vm.Measure7 = dto.strMeasure7;
			vm.Measure8 = dto.strMeasure8;
			vm.Measure9 = dto.strMeasure9;
			vm.Measure10 = dto.strMeasure10;
			vm.Measure11 = dto.strMeasure11;
			vm.Measure12 = dto.strMeasure12;
			vm.Measure13 = dto.strMeasure13;
			vm.Measure14 = dto.strMeasure14;
			vm.Measure15 = dto.strMeasure15;
			vm.ImageSource = dto.strImageSource;
			vm.ImageAttribution = dto.strImageAttribution;
			vm.CreativeCommonsConfirmed = dto.strCreativeCommonsConfirmed;
			vm.dateModified = dto.dateModified;

			return View(vm);
		}
	}
}
