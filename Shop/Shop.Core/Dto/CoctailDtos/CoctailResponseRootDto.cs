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
			[JsonProperty(PropertyName = "idDrink", NullValueHandling = NullValueHandling.Ignore)]
			public string idDrink { get; set; }

			[JsonProperty(PropertyName = "strDrink", NullValueHandling = NullValueHandling.Ignore)]
			public string strDrink { get; set; }

			[JsonProperty(PropertyName = "strDrinkAlternate", NullValueHandling = NullValueHandling.Ignore)]
			public object strDrinkAlternate { get; set; }

			[JsonProperty(PropertyName = "strTags", NullValueHandling = NullValueHandling.Ignore)]
			public object strTags { get; set; }

			[JsonProperty(PropertyName = "strVideo", NullValueHandling = NullValueHandling.Ignore)]
			public object strVideo { get; set; }

			[JsonProperty(PropertyName = "strCategory", NullValueHandling = NullValueHandling.Ignore)]
			public string strCategory { get; set; }

			[JsonProperty(PropertyName = "strIBA", NullValueHandling = NullValueHandling.Ignore)]
			public object strIBA { get; set; }

			[JsonProperty(PropertyName = "strAlcoholic", NullValueHandling = NullValueHandling.Ignore)]
			public string strAlcoholic { get; set; }

			[JsonProperty(PropertyName = "strGlass", NullValueHandling = NullValueHandling.Ignore)]
			public string strGlass { get; set; }

			[JsonProperty(PropertyName = "strInstructions", NullValueHandling = NullValueHandling.Ignore)]
			public string strInstructions { get; set; }

			[JsonProperty(PropertyName = "strInstructionsES", NullValueHandling = NullValueHandling.Ignore)]
			public string strInstructionsES { get; set; }

			[JsonProperty(PropertyName = "strInstructionsDE", NullValueHandling = NullValueHandling.Ignore)]
			public string strInstructionsDE { get; set; }

			[JsonProperty(PropertyName = "strInstructionsFR", NullValueHandling = NullValueHandling.Ignore)]
			public object strInstructionsFR { get; set; }

			[JsonProperty(PropertyName = "strInstructionsIT", NullValueHandling = NullValueHandling.Ignore)]
			public string strInstructionsIT { get; set; }

			[JsonProperty(PropertyName = "strInstructionsZHHANS", NullValueHandling = NullValueHandling.Ignore)]
			public object strInstructionsZHHANS { get; set; }

			[JsonProperty(PropertyName = "strInstructionsZHHANT", NullValueHandling = NullValueHandling.Ignore)]
			public object strInstructionsZHHANT { get; set; }

			[JsonProperty(PropertyName = "strDrinkThumb", NullValueHandling = NullValueHandling.Ignore)]
			public string strDrinkThumb { get; set; }

			[JsonProperty(PropertyName = "strIngredient1", NullValueHandling = NullValueHandling.Ignore)]
			public string strIngredient1 { get; set; }

			[JsonProperty(PropertyName = "strIngredient2", NullValueHandling = NullValueHandling.Ignore)]
			public string strIngredient2 { get; set; }

			[JsonProperty(PropertyName = "strIngredient3", NullValueHandling = NullValueHandling.Ignore)]
			public string strIngredient3 { get; set; }

			[JsonProperty(PropertyName = "strIngredient4", NullValueHandling = NullValueHandling.Ignore)]
			public string strIngredient4 { get; set; }

			[JsonProperty(PropertyName = "strIngredient5", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient5 { get; set; }

			[JsonProperty(PropertyName = "strIngredient6", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient6 { get; set; }

			[JsonProperty(PropertyName = "strIngredient7", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient7 { get; set; }

			[JsonProperty(PropertyName = "strIngredient8", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient8 { get; set; }

			[JsonProperty(PropertyName = "strIngredient9", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient9 { get; set; }

			[JsonProperty(PropertyName = "strIngredient10", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient10 { get; set; }

			[JsonProperty(PropertyName = "strIngredient11", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient11 { get; set; }

			[JsonProperty(PropertyName = "strIngredient12", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient12 { get; set; }

			[JsonProperty(PropertyName = "strIngredient13", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient13 { get; set; }

			[JsonProperty(PropertyName = "strIngredient14", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient14 { get; set; }

			[JsonProperty(PropertyName = "strIngredient15", NullValueHandling = NullValueHandling.Ignore)]
			public object strIngredient15 { get; set; }

			[JsonProperty(PropertyName = "strMeasure1", NullValueHandling = NullValueHandling.Ignore)]
			public string strMeasure1 { get; set; }

			[JsonProperty(PropertyName = "strMeasure2", NullValueHandling = NullValueHandling.Ignore)]
			public string strMeasure2 { get; set; }

			[JsonProperty(PropertyName = "strMeasure3", NullValueHandling = NullValueHandling.Ignore)]
			public string strMeasure3 { get; set; }

			[JsonProperty(PropertyName = "strMeasure4", NullValueHandling = NullValueHandling.Ignore)]
			public string strMeasure4 { get; set; }

			[JsonProperty(PropertyName = "strMeasure5", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure5 { get; set; }

			[JsonProperty(PropertyName = "strMeasure6", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure6 { get; set; }

			[JsonProperty(PropertyName = "strMeasure7", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure7 { get; set; }

			[JsonProperty(PropertyName = "strMeasure8", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure8 { get; set; }

			[JsonProperty(PropertyName = "strMeasure9", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure9 { get; set; }

			[JsonProperty(PropertyName = "strMeasure10", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure10 { get; set; }

			[JsonProperty(PropertyName = "strMeasure11", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure11 { get; set; }

			[JsonProperty(PropertyName = "strMeasure12", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure12 { get; set; }

			[JsonProperty(PropertyName = "strMeasure13", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure13 { get; set; }

			[JsonProperty(PropertyName = "strMeasure14", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure14 { get; set; }

			[JsonProperty(PropertyName = "strMeasure15", NullValueHandling = NullValueHandling.Ignore)]
			public object strMeasure15 { get; set; }

			[JsonProperty(PropertyName = "strImageSource", NullValueHandling = NullValueHandling.Ignore)]
			public object strImageSource { get; set; }

			[JsonProperty(PropertyName = "strImageAttribution", NullValueHandling = NullValueHandling.Ignore)]
			public object strImageAttribution { get; set; }

			[JsonProperty(PropertyName = "strCreativeCommonsConfirmed", NullValueHandling = NullValueHandling.Ignore)]
			public string strCreativeCommonsConfirmed { get; set; }

			[JsonProperty(PropertyName = "dateModified", NullValueHandling = NullValueHandling.Ignore)]
			public string dateModified { get; set; }
	}
}
