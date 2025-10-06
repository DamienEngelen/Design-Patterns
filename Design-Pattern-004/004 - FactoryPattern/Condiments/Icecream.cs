using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class IceCream : CondimentDecorator
    {
        public IceCream(Beverage beverage) : base(beverage) {}

        public override double cost()
        {
            double extraCost = 0.0;
            switch (this.Size)
            {
                case Size.TALL:
                    extraCost = 1.70;
                    break;
                case Size.GRANDE:
                    extraCost = 1.90;
                    break;
                case Size.VENDI:
                    extraCost = 2.10;
                    break;
                default:
                    extraCost = 1.70;
                    break;
            }
            return extraCost + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Ice Cream";
        }
    }
}