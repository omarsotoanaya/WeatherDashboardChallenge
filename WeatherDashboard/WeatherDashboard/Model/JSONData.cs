using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherDashboard.Model
{
    public class JSONData
    {
        public string City_Name { get; set; }
        public string Lon { get; set; }
        public string TimeZone { get; set; }
        public string Lat { get; set; }
        public string Country_Code { get; set; }
        public string State_Code { get; set; }
        public List<Weather> Data { get; set; }

    }
}
