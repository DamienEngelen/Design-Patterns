using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData)
        {
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            temperature = temp;
            sumTemperature += temp;
            countUpdated++;

            if (countUpdated == 1 || temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (countUpdated == 1 || temp < minTemp)
            {
                minTemp = temp;
            }

            Display();
        }

        public void Display()
        {
            // Print the average, maximum and minimum temperature. Use appropriate fields
            float avgTemp = sumTemperature / countUpdated;
            Console.WriteLine($"Gemiddelde/Max/Min temperatuur = {avgTemp:F1}/{maxTemp}/{minTemp}");
        }
    }
}
