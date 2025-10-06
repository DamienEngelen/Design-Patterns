using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Singleton
{
    public class ChocolateBoiler
    {
        private static readonly Lazy<ChocolateBoiler> instance =
            new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

        private bool empty;
        private bool boiled;

        // This code is only started when the boiler is empty
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler Instance => instance.Value;

        // To fill the boiler it must be empty and once it is full, we set the empty and boiled flag
        public void Fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Boiler filled.");
            }
        }
        // To drain the boiler, it must be full (non empty) and also boiled.
        // Once it is drained we set empty back to true
        public void Boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
                Console.WriteLine("Boiler boiled.");
            }
        }
        // To boil the mixture, the boiler has to be full and not already boiled.
        // Once it is boiled we set the boiled flag to true
        public void Drain()
        {
            if (!empty && boiled)
            {
                empty = true;
                Console.WriteLine("Boiler drained.");
            }
        }
    }
}
