using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size;

        protected string description = "Unknown";
        protected Beverage? baseBeverage = null;


        public virtual string GetDescription()
        {
            return description;
        }

        public virtual double cost()
        {
            double baseCost;
            switch (Size)
            {
                case Size.TALL:
                    baseCost = 1.50;
                    break;
                case Size.GRANDE:
                    baseCost = 2.00;
                    break;
                case Size.VENDI:
                    baseCost = 2.50;
                    break;
                default:
                    baseCost = 1.50;
                    break;
            }
            return baseCost;
        }
    }
}
