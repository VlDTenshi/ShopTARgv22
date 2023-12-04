using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.AccuWeatherDtos
{
    public class Country
    {
        [JsonPropertyName("_id")]
        public int _ID { get; set; }
        [JsonPropertyName("_1localizedname")]
        public string _LocalizedName { get; set; }
        [JsonPropertyName("_1englishname")]
        public string _EnglishName { get; set; }
    }
}
