using System.Text.Json.Serialization;

namespace Shop.Core.Dto.OpenWetaherDtos
{
	public class Weather
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }
		[JsonPropertyName("main")]
		public string Main { get; set; }
		[JsonPropertyName("description")]
		public string weather_Description { get; set; }
		[JsonPropertyName("icon")]
		public string weather_Icon { get; set; }
	}
}