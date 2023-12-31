using Newtonsoft.Json.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region RonVSKanye
            /*var client = new HttpClient();
            var quote = new RonVSKanyeAPI(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {quote.Kanye()}");

                Console.WriteLine($"Ron: {quote.Ron()}");

            }*/
            #endregion

            String Key = File.ReadAllText("appsettings.json");
            String APIKey = JObject.Parse(Key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your zipcode");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode},&units=imperial&appid={APIKey}";

            Console.WriteLine();
            Console.WriteLine($"It is currently {OpenWeatherMapAPI.GetTemp(apiCall)} degrees F in your location.");
        }


    }
 }
