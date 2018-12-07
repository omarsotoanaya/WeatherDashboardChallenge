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
        public JSONData GetWeather(string city)
        {
            // Default value is Obregon.
            if (string.IsNullOrEmpty(city))
                city = WebApiConstant.Cities.Cajeme.ToString();

            // Build the Url
            var url = string.Format("{0}city={1}&country{2}&key={3}", WebApiConstant.URL, city
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

    }
}