using Microsoft.VisualBasic;
using Nancy.Json;
using Nancy.Routing.Constraints;
using Shop.Core.Dto.Chuck;
using Shop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ApplicationServices.Services
{
	public class ChuckNorrisServices: IChuckNorrisServices
	{
		public async Task<OpenChuckNorrisResultDto>ChuckNorrisResult(OpenChuckNorrisResultDto dto)
		{
			var url = "https://api.chucknorris.io/jokes/random";

			using (WebClient client = new WebClient())
			{
				string json = client.DownloadString(url);
				openChuckNorrisResponseRootDto jokeResult = new JavaScriptSerializer().Deserialize<openChuckNorrisResponseRootDto>(json);
				//dto.Categories = jokeResult.Categories;
				dto.Created_at = jokeResult.CreatedAt;
				dto.Icon_url = jokeResult.Iconurl;
				dto.Id = jokeResult.Id;
				dto.Updated_at = jokeResult.UpdatedAt;
				dto.Url = jokeResult.Url;
				dto.Value = jokeResult.Value;
			}
			return dto;
		}
	}
}
