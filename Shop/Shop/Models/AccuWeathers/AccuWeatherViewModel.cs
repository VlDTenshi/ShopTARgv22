namespace Shop.Models.AccuWeathers
{
    public class AccuWeatherViewModel
    {
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string PrimaryPostalCode { get; set; }
        public string ID { get; set; }
        public string Localized_Name { get; set; }
        public string English_Name { get; set; }
        public string _ID { get; set; }
        public string _LocalizedName { get; set; }
        public string _EnglishName { get; set; }
        public string _1ID { get; set; }
        public string _1LocalizedName { get; set; }
        public string _1EnglishName { get; set; }
        public int Level { get; set; }
        public string LocalizedType { get; set; }
        public string EnglishType { get; set; }
        public string CountryID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int GmtOffset { get; set; }
        public bool IsDaylightSaving { get; set; }
        public DateTime NextOffsetChange { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
        public int _Value { get; set; }
        public string _Unit { get; set; }
        public int _UnitType { get; set; }
        public bool IsAlias { get; set; }
        public int _Level { get; set; }
        public string _2LocalizedName { get; set; }
        public string _2EnglishName { get; set; }
        public int Version { get; set; }
        public string AirQualityCurrentConditions { get; set; }
        public string AirQualityForecasts { get; set; }
        public string Alerts { get; set; }
        public string DailyPollenForecast { get; set; }
        public string ForecastConfidence { get; set; }
        public string FutureRadar { get; set; }
        public string MinuteCast { get; set; }
        public string Radar { get; set; }
        public string EffectiveDate { get; set; }
        public int EffectiveEpochDate { get; set; }
        public int Severity { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public string EndDate { get; set; }
        public int EndEpochDate { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
        public string Date1 { get; set; }
        public int EpochDate1 { get; set; }
        public int _1Value { get; set; }
        public string _1Unit { get; set; }
        public int _1UnitType { get; set; }
        public int _2Value { get; set; }
        public string _2Unit { get; set; }
        public int _2UnitType { get; set; }
        public int Icon { get; set; }
        public string IconPhrase { get; set; }
        public bool HasPrecipitation { get; set; }
        public string PrecipitationType { get; set; }
        public string PrecipitationItensity { get; set; }
        public int _Icon { get; set; }
        public string _IconPhrase { get; set; }
        public bool _HasPrecipitation { get; set; }
        public DateTime Date { get; set; }
        public int EpochDate { get; set; }
        public Temperature Temperature1 { get; set; }
        public Day Day1 { get; set; }
        public Night Night1 { get; set; }
        public List<string> Sources { get; set; }
        public string MobileLink1 { get; set; }
        public string Link1 { get; set; }
        public class DailyForecast
        {
            public DateTime Date { get; set; }
            public int EpochDate { get; set; }
            public Temperature Temperature { get; set; }
            public Day Day { get; set; }
            public Night Night { get; set; }
            public List<string> Sources { get; set; }
            public string MobileLink { get; set; }
            public string Link { get; set; }
        }

        public class Day
        {
            public int Icon { get; set; }
            public string IconPhrase { get; set; }
            public bool HasPrecipitation { get; set; }
            public string PrecipitationType { get; set; }
            public string PrecipitationIntensity { get; set; }
        }

        public class Headline
        {
            public DateTime EffectiveDate { get; set; }
            public int EffectiveEpochDate { get; set; }
            public int Severity { get; set; }
            public string Text { get; set; }
            public string Category { get; set; }
            public DateTime EndDate { get; set; }
            public int EndEpochDate { get; set; }
            public string MobileLink { get; set; }
            public string Link { get; set; }
        }

        public class Maximum
        {
            public int Value { get; set; }
            public string Unit { get; set; }
            public int UnitType { get; set; }
        }

        public class Minimum
        {
            public int Value { get; set; }
            public string Unit { get; set; }
            public int UnitType { get; set; }
        }
        public class Night
        {
            public int Icon { get; set; }
            public string IconPhrase { get; set; }
            public bool HasPrecipitation { get; set; }
            public string PrecipitationType { get; set; }
            public string PrecipitationIntensity { get; set; }
        }
        public Headline Headline1 { get; set; }
        public List<DailyForecast> DailyForecasts { get; set; }
        public class Root
        {
            public Headline Headline { get; set; }
            public List<DailyForecast> DailyForecasts { get; set; }
        }

        public class Temperature
        {
            public Minimum Minimum { get; set; }
            public Maximum Maximum { get; set; }
        }
    }
}
