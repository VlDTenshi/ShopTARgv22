namespace Shop.Models.AccuWeathers
{
	public class AccuWeatherViewModel
	{
		public string LocalizedName { get; set; }
		public string Key { get; set; }
		public int Minimum { get; set; }
		public int Maximum { get; set; }
		public string Link { get; set; }
	}
}
