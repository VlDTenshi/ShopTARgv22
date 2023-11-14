using System.Text.Json.Serialization;

namespace Shop.Core.Dto.OpenWetaherDtos
{
	public class Sys
	{
		[JsonPropertyName("type")]
		public int Type { get; set; }
		[JsonPropertyName("id")]
		public int Id { get; set; }
		[JsonPropertyName("country")]
		public string Country { get; set; }
		[JsonPropertyName("sunrise")]
		public int sunrise { get; set; }
		[JsonPropertyName("sunset")]
		public int sunset { get; set; }
	}
}