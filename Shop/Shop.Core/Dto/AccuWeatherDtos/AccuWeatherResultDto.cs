using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Dto.AccuWeatherDtos
{
    public class AccuWeatherResultDto
	{


		public string LocalizedName { get; set; }
		public string Key { get; set; }
		public int Minimum { get; set; }
		public int Maximum { get; set; }
		public string Link { get; set; }




	}
}
