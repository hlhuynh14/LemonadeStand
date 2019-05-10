using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft;


namespace LemonadeStand
{
    class Program
    {
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
                    WeatherReport weatherReport = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherReport>(result);
                   



                }
            }
        }
    }
}
