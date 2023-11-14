using System.Text.Json.Serialization;

namespace Shop.Core.Dto.OpenWetaherDtos
{
	public class Rain
	{
		[JsonPropertyName("1h")]
		public double _1h { get; set; }
	}
}