using System;

namespace Value_Reference_Type
{
    public class Forecast
    {
        public Int32 Temperature { get; set; }
        public Int32 Pressure { get; set; }
    }
    class Program
    {
        public static void ChangeTheString(string weather) { weather = "Sunny"; }
        public static void ChangeTheArray(string[] rainyDays) { rainyDays[1] = "Sunday"; }
        public static void ChangeTheClassInstance(Forecast forecast) { forecast.Temperature = 35; }

        static void Main(string[] args)
        {
            string weather = "rainy";
            ChangeTheString(weather);
            Console.WriteLine($"The weather is " + weather);

            string[] rainyDays = { "Monday", "Friday" };
            ChangeTheArray(rainyDays);
            Console.WriteLine($"The rainy days are " + rainyDays[0] + " and " + rainyDays[1]);

            Forecast forecast = new Forecast { Pressure = 700, Temperature = 20 };
            ChangeTheClassInstance(forecast);
            Console.WriteLine("The temparature is " + forecast.Temperature + " C");
            Console.ReadKey();
        }
    }
}
