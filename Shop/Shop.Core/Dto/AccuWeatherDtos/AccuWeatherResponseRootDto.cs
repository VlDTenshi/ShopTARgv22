using Shop.Core.Dto.OpenWetaherDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.AccuWeatherDtos
{
    public class AccuWeatherResponseRootDto
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }
        [JsonPropertyName("localizedname")]
        public string LocalizedName { get; set; }
        [JsonPropertyName("region")]
        public Region Region { get; set; }
        [JsonPropertyName("country")]
        public Country Country { get; set; }
        [JsonPropertyName("administrativearea")]
        public AdministrativeArea AdministrativeArea { get; set; }
        [JsonPropertyName("timezone")]
        public Time_Zone Time_Zone { get; set; }
        [JsonPropertyName("geoposition")]
        public Geoposition Geoposition { get; set; }
        [JsonPropertyName("elevation")]
        public Elevation Elevation { get; set; }
        [JsonPropertyName("metric")]
        public Metric Metric { get; set; }
        [JsonPropertyName("imperial")]
        public Imperial Imperial { get; set; }
        [JsonPropertyName("supplementaladminareas")]
        public Supplementaladminareas Supplementaladminareas { get; set; }
        [JsonPropertyName("datasets")]
        public Datasets Datasets{ get; set; }
    }
}
