using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherDashboard.Controllers.Api;
using WeatherDashboard.Model;


namespace WeatherDashboard.Controllers
{
    public class WeatherController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Weather> GetWeathers(int cityId)
        {

            var jSONData = new WeatherbitController();
            var forecast = jSONData.GetJSONInfo(cityId);

            return forecast.Data;

        }

        public ActionResult ForecastIndex(int cityId)
        {
            var getWeather = GetWeathers(cityId);

            return View("ForecastIndex", getWeather);
        }

        [HttpPost]
        public ActionResult OnChange(int cityId)
        {

            var getWeather = GetWeathers(cityId);

            return View("ForecastIndex", getWeather);
        }
    }
}