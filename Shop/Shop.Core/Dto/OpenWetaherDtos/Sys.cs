using System.Text.Json.Serialization;

namespace Shop.Core.Dto.OpenWetaherDtos
{
	public class Sys
	{
		[JsonPropertyName("type")]
		public int sys_Type { get; set; }
		[JsonPropertyName("id")]
		public int sys_Id { get; set; }
		[JsonPropertyName("country")]
		public string sys_Country { get; set; }
		[JsonPropertyName("sunrise")]
		public int sys_sunrise { get; set; }
		[JsonPropertyName("sunset")]
		public int sys_sunset { get; set; }
	}
}