using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            int relativeHumidity;
            double windChill;
            double Heatindex;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);

            if (temperature > 50)
            {   Console.WriteLine("Enter the Relative Humidity");

                input = Console.ReadLine();

                relativeHumidity = int.Parse(input);

                Heatindex = temperature + 61 + ((temperature - 68) * 1.2) + (relativeHumidity * 0.094);

                Console.WriteLine("The Heat Index is" + Heatindex);
            }
            else
            {
                Console.WriteLine("Enter the Windspeed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);
            }

      
          
        }
    }
}
