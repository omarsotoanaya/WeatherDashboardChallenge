using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherDashboard.Model
{
    public static class WebApiConstant
    {
        public static string URL = "http://api.weatherbit.io/v2.0/forecast/daily?";
        public static string KEY = "054964adc87d4b44a3e2b8708a914697";
        public static string COUNTRY = "MX";
        
        public enum Cities
        {
            Cajeme,
            Hermosillo,
            Navojoa,
            Nogales
        }

    }
}
