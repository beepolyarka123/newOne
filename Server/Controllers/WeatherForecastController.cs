using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using штвн.Shared;

namespace штвн.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get ()
        {
            // Добавление
            using (_20ПИ32ДПолярушОлегContext db = new _20ПИ32ДПолярушОлегContext())
            {
                РегистрацияНаСайте1 user1 = new РегистрацияНаСайте1 { RegId = 123, Имя = "Andrew", Фамилия = "Petrov", Ник = "beepolyarka", Возраст = 21, EMailИлиТелефон = 73132465475, Пароль = "zzzzzzzzz", ПодтверждениеПароля = "zzzzzzzzz", ВашаСтудия = "Гейммастерс" };
                // Добавление
                db.РегистрацияНаСайте1.Add(user1);
                db.SaveChanges();
            }
            return null;
        }
    }
}
