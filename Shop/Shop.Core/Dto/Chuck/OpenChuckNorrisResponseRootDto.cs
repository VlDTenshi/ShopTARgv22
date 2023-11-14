﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.Chuck
{
	public class openChuckNorrisResponseRootDto
	{
		[JsonPropertyName("categories")]
		public List<string> Categories { get; set; }
		[JsonPropertyName("created_at")]
		public string CreatedAt { get; set; }
		[JsonPropertyName("icon_url")]
		public string Iconurl { get; set; }
		[JsonPropertyName("id")]
		public string Id { get; set; }
		[JsonPropertyName("updated_at")]
		public string UpdatedAt { get; set;}
		[JsonPropertyName("url")]
		public string Url { get; set; }
		[JsonPropertyName("value")]
		public string Value { get; set; }
	}
}
