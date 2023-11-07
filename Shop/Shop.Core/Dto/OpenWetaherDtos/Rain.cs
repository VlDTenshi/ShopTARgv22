using System.Text.Json.Serialization;

namespace Shop.Core.Dto.OpenWetaherDtos
{
	public class Rain
	{
		[JsonPropertyName("1h")]
		public double rain_1h { get; set; }
	}
}