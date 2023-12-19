using Nancy.Json;
using Shop.Core.Dto.CoctailDtos;
using Shop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ApplicationServices.Services
{
	public class CoctailServices: ICoctailServices
	{
		public async Task<CoctailResultDto>CoctailResult(CoctailResultDto dto)
		{
			//string idCoctailAPI = "1";
			//{ idCoctailAPI}
			string url = $"https://www.thecocktaildb.com/api/json/v1/1/search.php?s={dto.strDrink}";

			using (WebClient client = new WebClient())
			{
				string json = client.DownloadString(url);
				CoctailResponseRootDto coctailResult = new JavaScriptSerializer().Deserialize<CoctailResponseRootDto>(json);

				dto.idDrink = coctailResult.idDrink;
				dto.strDrink = coctailResult.strDrink;
				dto.strDrinkAlternate = coctailResult.strDrinkAlternate;
				dto.strTags = coctailResult.strTags;
				dto.strVideo = coctailResult.strVideo;
				dto.strCategory = coctailResult.strCategory;
				dto.strIBA = coctailResult.strIBA;
				dto.strAlcoholic = coctailResult.strAlcoholic;
				dto.strGlass = coctailResult.strGlass;
				dto.strInstructions = coctailResult.strInstructions;
				dto.strInstructionsES = coctailResult.strInstructionsES;
				dto.strInstructionsDE = coctailResult.strInstructionsDE;
				dto.strInstructionsFR = coctailResult.strInstructionsFR;
				dto.strInstructionsIT = coctailResult.strInstructionsIT;
				dto.strInstructionsZHHANS = coctailResult.strInstructionsZHHANS;
				dto.strInstructionsZHHANT = coctailResult.strInstructionsZHHANT;
				dto.strDrinkThumb = coctailResult.strDrinkThumb;
				dto.strIngredient1 = coctailResult.strIngredient1;
				dto.strIngredient2 = coctailResult.strIngredient2;
				dto.strIngredient3 = coctailResult.strIngredient3;
				dto.strIngredient4 = coctailResult.strIngredient4;
				dto.strIngredient5 = coctailResult.strIngredient5;
				dto.strIngredient6 = coctailResult.strIngredient6;
				dto.strIngredient7 = coctailResult.strIngredient7;
				dto.strIngredient8 = coctailResult.strIngredient8;
				dto.strIngredient9 = coctailResult.strIngredient9;
				dto.strIngredient10 = coctailResult.strIngredient10;
				dto.strIngredient11 = coctailResult.strIngredient11;
				dto.strIngredient12 = coctailResult.strIngredient12;
				dto.strIngredient13 = coctailResult.strIngredient13;
				dto.strIngredient14 = coctailResult.strIngredient14;
				dto.strIngredient15 = coctailResult.strIngredient15;
				dto.strMeasure1 = coctailResult.strMeasure1;
				dto.strMeasure2 = coctailResult.strMeasure2;
				dto.strMeasure3 = coctailResult.strMeasure3;
				dto.strMeasure4 = coctailResult.strMeasure4;
				dto.strMeasure5 = coctailResult.strMeasure5;
				dto.strMeasure6 = coctailResult.strMeasure6;
				dto.strMeasure7 = coctailResult.strMeasure7;
				dto.strMeasure8 = coctailResult.strMeasure8;
				dto.strMeasure9 = coctailResult.strMeasure9;
				dto.strMeasure10 = coctailResult.strMeasure10;
				dto.strMeasure11 = coctailResult.strMeasure11;
				dto.strMeasure12 = coctailResult.strMeasure12;
				dto.strMeasure13 = coctailResult.strMeasure13;
				dto.strMeasure14 = coctailResult.strMeasure14;
				dto.strMeasure15 = coctailResult.strMeasure15;
				dto.strImageSource = coctailResult.strImageSource;
				dto.strImageAttribution = coctailResult.strImageAttribution;
				dto.strCreativeCommonsConfirmed = coctailResult.strCreativeCommonsConfirmed;
				dto.dateModified = coctailResult.dateModified;
			}
			return dto;
		}
	}
}
