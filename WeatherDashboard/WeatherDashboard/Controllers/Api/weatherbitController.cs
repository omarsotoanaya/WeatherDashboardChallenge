using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherDashboard.Model;
using Newtonsoft.Json;

namespace WeatherDashboard.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/weatherbit")]
    public class WeatherbitController : Controller
    {
        [HttpGet]
        public JSONData GetJSONInfo(int cityId)
        {
            // Default value is Obregon.
            string cityName = GetCityById(cityId);

            // Build the Url
            var url = string.Format("{0}city={1}&country{2}&key={3}", WebApiConstant.URL, cityName
               , WebApiConstant.COUNTRY, WebApiConstant.KEY);

            using (WebClient webClient = new WebClient())
            {
                // Get our webApi Response.
                string JSONResponse = webClient.DownloadString(url);

                // Convert the Json string to a series of objects.
                var weatherCollection = JsonConvert.DeserializeObject<JSONData>(JSONResponse);

                return weatherCollection;
            }

        }

        private string GetCityById(int cityId)
        {
            var city = "";
            switch (cityId)
            {
                case 0:
                    city = "Cajeme";
                    break;

                case 1:
                    city = "Hermosillo";
                    break;

                case 2:
                    city = "Navojoa";
                    break;

                case 3:
                    city = "Nogales";
                    break;

                default:
                    city = "Cajeme";
                    break;

            }

            return city;
        }

    }
}