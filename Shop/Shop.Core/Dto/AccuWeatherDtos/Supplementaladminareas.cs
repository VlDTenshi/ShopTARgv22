using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.AccuWeatherDtos
{
    public class Supplementaladminareas
    {
        [JsonPropertyName("level")]
        public int Level { get; set; }
        [JsonPropertyName("_2localizedname")]
        public string _2LocalizedName { get; set; }
        [JsonPropertyName("_2englishname")]
        public string _2EnglishName { get; set; }
    }
}
