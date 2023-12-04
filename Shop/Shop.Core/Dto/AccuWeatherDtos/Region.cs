using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.AccuWeatherDtos
{
    public class Region
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("localized_name")]
        public string Localized_Name { get; set; }
        [JsonPropertyName("english_name")]
        public double English_Name { get; set; }
    }
}
