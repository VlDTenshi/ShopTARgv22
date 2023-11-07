using System.Text.Json.Serialization;

namespace Shop.Core.Dto.OpenWetaherDtos
{
	public class Wind
	{
		[JsonPropertyName("speed")]
		public double wind_Speed { get; set; }
		[JsonPropertyName("deg")]
		public int wind_Deg { get; set; }
		[JsonPropertyName("gust")]
		public double wind_Gust { get; set; }
	}
}