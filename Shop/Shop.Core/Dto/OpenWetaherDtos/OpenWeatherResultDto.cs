using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Dto.OpenWetaherDtos
{
    public class OpenWeatherResultDto
    {
        public string City { get; set; }
        public double Lon { get; set; }
        public double Lat { get; set; }
        public int weather_Id { get; set; }
        public string weather_Main { get; set; }
        public string weather_Description { get; set; }
        public string weather_Icon { get; set; }
        public string Base { get; set; }
        public double main_Temp { get; set; }
        public double main_Feels_like { get; set; }
        public double main_Temp_min { get; set; }
        public double main_Temp_max { get; set; }
        public int main_Pressure { get; set; }
        public int main_Humidity { get; set; }
        public double main_Sea_level { get; set; }
        public double main_Grnd_level { get; set; }
        public int Visibility { get; set; }
        public double wind_Speed { get; set; }
        public int wind_Deg { get; set; }
        public double wind_Gust { get; set; }
        public double rain_1h { get; set; }
        public int clouds_All { get; set; }
        public int Dt { get; set; }
        public int sys_Type { get; set; }
        public int sys_Id { get; set; }
        public string sys_Country { get; set; }
        public int sys_sunrise { get; set; }
        public int sys_sunset { get; set; }
        public int Timezone { get; set; }
        public int main_Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }
}
