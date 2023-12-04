using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.AccuWeatherDtos
{
    public class Imperial
    {
        [JsonPropertyName("_value")]
        public int _Value { get; set; }
        [JsonPropertyName("_unit")]
        public string _Unit { get; set; }
        [JsonPropertyName("_unittype")]
        public int _UnitType { get; set; }
    }
}
