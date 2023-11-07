using System.Text.Json.Serialization;

namespace Shop.Core.Dto.OpenWetaherDtos
{
	public class Main
	{
		[JsonPropertyName("temp")]
		public double main_Temp { get; set; }
		[JsonPropertyName("feels_like")]
		public double main_Feels_like { get; set; }
		[JsonPropertyName("temp_min")]
		public double main_Temp_min { get; set; }
		[JsonPropertyName("temp_max")]
		public double main_Temp_max { get; set; }
		[JsonPropertyName("pressure")]
		public int main_Pressure { get; set; }
		[JsonPropertyName("humidity")]
		public int main_Humidity { get; set; }
		[JsonPropertyName("sea_level")]
		public double main_Sea_level { get; set; }
		[JsonPropertyName("grnd_level")]
		public double main_Grnd_level { get; set; }
	}
}