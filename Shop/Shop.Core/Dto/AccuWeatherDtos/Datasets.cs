using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.AccuWeatherDtos
{
    public class Datasets
    {
        [JsonPropertyName("airqualitycurrentconditions")]
        public string AirQualityCurrentConditions { get; set; }
        [JsonPropertyName("airqualityforecasts")]
        public string AirQualityForecasts { get; set; }
        [JsonPropertyName("alerts")]
        public string Alerts { get; set; }
        [JsonPropertyName("dailypollenforecast")]
        public string DailyPollenForecast { get; set; }
        [JsonPropertyName("forecastconfidence")]
        public string ForecastConfidence { get; set; }
        [JsonPropertyName("futureradar")]
        public string FutureRadar { get; set; }
        [JsonPropertyName("minutecast")]
        public string MinuteCast { get; set; }
        [JsonPropertyName("radar")]
        public string Radar { get; set; }
    }
}
