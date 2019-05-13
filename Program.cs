using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace LemonadeStand
{
    class Program
    {
        public static string weatherDescription;
        public static double temperatureDescription;

        static void Main(string[] args)
        {
           
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/weather?q=Milwaukee&appid=d5442e2231ccb440359be5565ad85d2a");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            GetWeather(client).Wait();
            



            Game GameStart = new Game();
            GameStart.StartGame();
        }

        static async Task GetWeather(HttpClient cons)
        {
            using (cons)
            {
                HttpResponseMessage res = await cons.GetAsync("");

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    string result = await res.Content.ReadAsStringAsync();
                    var forecast = JObject.Parse(result);
                    weatherDescription = forecast["weather"][0]["main"].ToString();
                    temperatureDescription = double.Parse(forecast["main"]["temp"].ToString());
                    temperatureDescription = ConvertToFahrenheit(temperatureDescription);


                }
            } 
        }

   
        static double ConvertToFahrenheit( double temperature)
        {
             temperature = (temperature - 273) * (18 / 10) + 32;
            return temperature;
        }

    }
}
