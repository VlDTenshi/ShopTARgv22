using System.ComponentModel.DataAnnotations;

namespace Shop.Models.Coctails
{
	public class SearchCoctailViewModel
	{
		[Required(ErrorMessage = "You must enter a drink name!")]
		[RegularExpression("^[A-Za-z]+$", ErrorMessage = "Only text allowed")]
		[StringLength(20, MinimumLength = 2, ErrorMessage = "Enter a city name greater than 2 and less than 20 characters!")]
		[Display(Name = "Drink Name")]
		public string strDrink { get; set; }
	}
}
