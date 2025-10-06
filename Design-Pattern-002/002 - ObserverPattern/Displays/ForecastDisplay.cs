using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData)
        {
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            if (temperature > 25 && humidity < 80)
            {
                Console.WriteLine("Forecast: Weer wordt beter!");
            }
            else if (temperature < 20 || humidity > 90)
            {
                Console.WriteLine("Forecast: Pas op voor koel, regenachtig weer");
            }
            else
            {
                Console.WriteLine("Forecast: Meer van hetzelfde");
            }
        }
    }
}
