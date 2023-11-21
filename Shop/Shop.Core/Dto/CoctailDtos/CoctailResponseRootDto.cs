using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.CoctailDtos
{
	public class CoctailResponseRootDto
	{
			[JsonProperty(PropertyName = "id_Drink", NullValueHandling = NullValueHandling.Ignore)]
			public string idDrink { get; set; }

			[JsonProperty(PropertyName = "str_Drink", NullValueHandling = NullValueHandling.Ignore)]
			public string strDrink { get; set; }

			[JsonProperty(PropertyName = "str_DrinkAlternate", NullValueHandling = NullValueHandling.Ignore)]
			public object strDrinkAlternate { get; set; }

			[JsonProperty(PropertyName = "str_Tags", NullValueHandling = NullValueHandling.Ignore)]
			public object strTags { get; set; }

			[JsonProperty(PropertyName = "str_Video", NullValueHandling = NullValueHandling.Ignore)]
			public object strVideo { get; set; }

			[JsonProperty(PropertyName = "str_Category", NullValueHandling = NullValueHandling.Ignore)]
			public string strCategory { get; set; }

			[JsonProperty(PropertyName = "str_IBA", NullValueHandling = NullValueHandling.Ignore)]
			public object strIBA { get; set; }

			[JsonProperty(PropertyName = "str_Alcoholic", NullValueHandling = NullValueHandling.Ignore)]
			public string strAlcoholic { get; set; }

			[JsonProperty(PropertyName = "str_Glass", NullValueHandling = NullValueHandling.Ignore)]
			public string strGlass { get; set; }

			[JsonProperty(PropertyName = "str_Instructions", NullValueHandling = NullValueHandling.Ignore)]
			public string strInstructions { get; set; }

			[JsonProperty(PropertyName = "str_InstructionsES", NullValueHandling = NullValueHandling.Ignore)]
			public string strInstructionsES { get; set; }

			[JsonProperty(PropertyName = "str_InstructionsDE", NullValueHandling = NullValueHandling.Ignore)]
			public string strInstructionsDE { get; set; }

			[JsonProperty(PropertyName = "str_InstructionsFR", NullValueHandling = NullValueHandling.Ignore)]
			public object strInstructionsFR { get; set; }

			[JsonProperty(PropertyName = "str_InstructionsIT", NullValueHandling = NullValueHandling.Ignore)]
			public string strInstructionsIT { get; set; }

			[JsonProperty(PropertyName = "str_InstructionsZHHANS", NullValueHandling = NullValueHandling.Ignore)]
			public object strInstructionsZHHANS { get; set; }

			[JsonProperty(PropertyName = "str_InstructionsZHHANT", NullValueHandling = NullValueHandling.Ignore)]
			public object strInstructionsZHHANT { get; set; }

			[JsonProperty(PropertyName = "str_DrinkThumb", NullValueHandling = NullValueHandling.Ignore)]
			public string strDrinkThumb { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient1", NullValueHandling = NullValueHandling.Ignore)]
			public string strIngredient1 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient2", NullValueHandling = NullValueHandling.Ignore)]
			public string strIngredient2 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient3", NullValueHandling = NullValueHandling.Ignore)]
			public string strIngredient3 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient4", NullValueHandling = NullValueHandling.Ignore)]
			public string strIngredient4 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient5", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient5 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient6", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient6 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient7", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient7 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient8", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient8 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient9", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient9 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient10", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient10 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient11", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient11 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient12", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient12 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient13", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient13 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient14", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient14 { get; set; }

			[JsonProperty(PropertyName = "str_Ingredient15", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient15 { get; set; }

			[JsonProperty(PropertyName = "str_Measure1", NullValueHandling = NullValueHandling.Ignore)]
			public string strMeasure1 { get; set; }

			[JsonProperty(PropertyName = "str_Measure2", NullValueHandling = NullValueHandling.Ignore)]
			public string strMeasure2 { get; set; }

			[JsonProperty(PropertyName = "str_Measure3", NullValueHandling = NullValueHandling.Ignore)]
			public string strMeasure3 { get; set; }

			[JsonProperty(PropertyName = "str_Measure4", NullValueHandling = NullValueHandling.Ignore)]
			public string strMeasure4 { get; set; }

			[JsonProperty(PropertyName = "str_Measure5", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure5 { get; set; }

			[JsonProperty(PropertyName = "str_Measure6", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure6 { get; set; }

			[JsonProperty(PropertyName = "str_Measure7", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure7 { get; set; }

			[JsonProperty(PropertyName = "str_Measure8", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure8 { get; set; }

			[JsonProperty(PropertyName = "str_Measure9", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure9 { get; set; }

			[JsonProperty(PropertyName = "str_Measure10", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure10 { get; set; }

			[JsonProperty(PropertyName = "str_Measure11", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure11 { get; set; }

			[JsonProperty(PropertyName = "str_Measure12", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure12 { get; set; }

			[JsonProperty(PropertyName = "str_Measure13", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure13 { get; set; }

			[JsonProperty(PropertyName = "str_Measure14", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure14 { get; set; }

			[JsonProperty(PropertyName = "str_Measure15", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure15 { get; set; }

			[JsonProperty(PropertyName = "str_ImageSource", NullValueHandling = NullValueHandling.Ignore)]
			public object strImageSource { get; set; }

			[JsonProperty(PropertyName = "str_ImageAttribution", NullValueHandling = NullValueHandling.Ignore)]
			public object strImageAttribution { get; set; }

			[JsonProperty(PropertyName = "str_CreativeCommonsConfirmed", NullValueHandling = NullValueHandling.Ignore)]
			public string strCreativeCommonsConfirmed { get; set; }

			[JsonProperty(PropertyName = "date_Modified", NullValueHandling = NullValueHandling.Ignore)]
			public string dateModified { get; set; }
	}
}
