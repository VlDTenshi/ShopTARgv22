﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Shop.Core.Dto.Chuck
{
	public class OpenChuckNorrisResultDto
	{
		public string Categories { get; set; }
		public string Created_at { get; set; }
		public string Icon_url { get; set; }
		public string Id { get; set; }
		public string Updated_at { get; set; }
		public string Url { get; set; }
		public string Value { get; set; }
	}
}
