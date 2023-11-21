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
			[JsonProperty("idDrink", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("id_Drink")]
			public string idDrink { get; set; }

			[JsonProperty("strDrink", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Drink")]
			public string strDrink { get; set; }

			[JsonProperty("strDrinkAlternate", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_DrinkAlternate")]
			public object strDrinkAlternate { get; set; }

			[JsonProperty("strTags", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Tags")]
			public object strTags { get; set; }

			[JsonProperty("strVideo", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Video")]
			public object strVideo { get; set; }

			[JsonProperty("strCategory", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Category")]
			public string strCategory { get; set; }

			[JsonProperty("strIBA", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_IBA")]
			public object strIBA { get; set; }

			[JsonProperty("strAlcoholic", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Alcoholic")]
			public string strAlcoholic { get; set; }

			[JsonProperty("strGlass", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Glass")]
			public string strGlass { get; set; }

			[JsonProperty("strInstructions", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Instructions")]
			public string strInstructions { get; set; }

			[JsonProperty("strInstructionsES", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_InstructionsES")]
			public string strInstructionsES { get; set; }

			[JsonProperty("strInstructionsDE", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_InstructionsDE")]
			public string strInstructionsDE { get; set; }

			[JsonProperty("strInstructionsFR", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_InstructionsFR")]
			public object strInstructionsFR { get; set; }

			[JsonProperty("strInstructionsIT", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_InstructionsIT")]
			public string strInstructionsIT { get; set; }

			[JsonProperty("strInstructionsZH-HANS", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_InstructionsZH-HANS")]
			public object strInstructionsZHHANS { get; set; }

			[JsonProperty("strInstructionsZH-HANT", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_InstructionsZH-HANT")]
			public object strInstructionsZHHANT { get; set; }

			[JsonProperty("strDrinkThumb", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_DrinkThumb")]
			public string strDrinkThumb { get; set; }

			[JsonProperty("strIngredient1", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient1")]
			public string strIngredient1 { get; set; }

			[JsonProperty("strIngredient2", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient2")]
			public string strIngredient2 { get; set; }

			[JsonProperty("strIngredient3", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient3")]
			public string strIngredient3 { get; set; }

			[JsonProperty("strIngredient4", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient4")]
			public string strIngredient4 { get; set; }

			[JsonProperty("strIngredient5", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient5")]
			public object strIngredient5 { get; set; }

			[JsonProperty("strIngredient6", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient6")]
			public object strIngredient6 { get; set; }

			[JsonProperty("strIngredient7", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient7")]
			public object strIngredient7 { get; set; }

			[JsonProperty("strIngredient8", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient8")]
			public object strIngredient8 { get; set; }

			[JsonProperty("strIngredient9", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient9")]
			public object strIngredient9 { get; set; }

			[JsonProperty("strIngredient10", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient10")]
			public object strIngredient10 { get; set; }

			[JsonProperty("strIngredient11", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient11")]
			public object strIngredient11 { get; set; }

			[JsonProperty("strIngredient12", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient12")]
			public object strIngredient12 { get; set; }

			[JsonProperty("strIngredient13", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient13")]
			public object strIngredient13 { get; set; }

			[JsonProperty("strIngredient14", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient14")]
			public object strIngredient14 { get; set; }

			[JsonProperty("strIngredient15", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Ingredient15")]
			public object strIngredient15 { get; set; }

			[JsonProperty("strMeasure1", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure1")]
			public string strMeasure1 { get; set; }

			[JsonProperty("strMeasure2", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure2")]
			public string strMeasure2 { get; set; }

			[JsonProperty("strMeasure3", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure3")]
			public string strMeasure3 { get; set; }

			[JsonProperty("strMeasure4", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure4")]
			public string strMeasure4 { get; set; }

			[JsonProperty("strMeasure5", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure5")]
			public object strMeasure5 { get; set; }

			[JsonProperty("strMeasure6", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure6")]
			public object strMeasure6 { get; set; }

			[JsonProperty("strMeasure7", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure7")]
			public object strMeasure7 { get; set; }

			[JsonProperty("strMeasure8", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure8")]
			public object strMeasure8 { get; set; }

			[JsonProperty("strMeasure9", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure9")]
			public object strMeasure9 { get; set; }

			[JsonProperty("strMeasure10", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure10")]
			public object strMeasure10 { get; set; }

			[JsonProperty("strMeasure11", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure11")]
			public object strMeasure11 { get; set; }

			[JsonProperty("strMeasure12", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure12")]
			public object strMeasure12 { get; set; }

			[JsonProperty("strMeasure13", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure13")]
			public object strMeasure13 { get; set; }

			[JsonProperty("strMeasure14", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure14")]
			public object strMeasure14 { get; set; }

			[JsonProperty("strMeasure15", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_Measure15")]
			public object strMeasure15 { get; set; }

			[JsonProperty("strImageSource", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_ImageSource")]
			public object strImageSource { get; set; }

			[JsonProperty("strImageAttribution", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_ImageAttribution")]
			public object strImageAttribution { get; set; }

			[JsonProperty("strCreativeCommonsConfirmed", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("str_CreativeCommonsConfirmed")]
			public string strCreativeCommonsConfirmed { get; set; }

			[JsonProperty("dateModified", NullValueHandling = NullValueHandling.Ignore)]
			[JsonPropertyName("date_Modified")]
			public string dateModified { get; set; }
	}
}
