using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.AccuWeatherDtos
{
    public class Time_Zone
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }
        [JsonPropertyName("name")]
        public double Name { get; set; }
        [JsonPropertyName("gmtoffset")]
        public int GmtOffset { get; set; }
        [JsonPropertyName("isdaylightsaving")]
        public bool IsDaylightSaving { get; set; }
        [JsonPropertyName("nextoffsetchange")]
        public DateTime NextOffsetChange { get; set; }
    }
}
