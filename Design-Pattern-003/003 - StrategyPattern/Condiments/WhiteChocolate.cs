using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class WhiteChocolate : CondimentDecorator
    {
        public WhiteChocolate(Beverage beverage) : base(beverage) {}

        public override double cost()
        {
            double extraCost = 0.0;
            switch (this.Size)
            {
                case Size.TALL:
                    extraCost = 1.71;
                    break;
                case Size.GRANDE:
                    extraCost = 1.91;
                    break;
                case Size.VENDI:
                    extraCost = 2.11;
                    break;
                default:
                    extraCost = 1.71;
                    break;
            }
            return extraCost + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", White Chocolate";
        }
    }
}