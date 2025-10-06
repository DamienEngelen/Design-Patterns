using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Lemon : CondimentDecorator
    {
        public Lemon(Beverage beverage) : base(beverage) {}

        public override double cost()
        {
            double extraCost = 0.0;
            switch (this.Size)
            {
                case Size.TALL:
                    extraCost = 0.73;
                    break;
                case Size.GRANDE:
                    extraCost = 0.83;
                    break;
                case Size.VENDI:
                    extraCost = 0.93;
                    break;
                default:
                    extraCost = 0.73;
                    break;
            }
            return extraCost + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Lemon";
        }
    }
}