using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.AccuWeatherDtos
{
    public class AdministrativeArea
    {
        [JsonPropertyName("_1id")]
        public int _1ID { get; set; }
        [JsonPropertyName("_1localizedname")]
        public string _1LocalizedName { get; set; }
        [JsonPropertyName("_1englishname")]
        public string _1EnglishName { get; set; }
        [JsonPropertyName("level")]
        public int Level { get; set; }
        [JsonPropertyName("localizedtype")]
        public string LocalizedType { get; set; }
        [JsonPropertyName("englishtype")]
        public string EnglishType { get; set; }
        [JsonPropertyName("countryid")]
        public string CountryID { get; set; }
    }
}
