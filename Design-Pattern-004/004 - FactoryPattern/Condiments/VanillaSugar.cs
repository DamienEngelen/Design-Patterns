using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class VanillaSugar : CondimentDecorator
    {
        public VanillaSugar(Beverage beverage) : base(beverage) {}

        public override double cost()
        {
            double extraCost = 0.0;
            switch (this.Size)
            {
                case Size.TALL:
                    extraCost = 0.95;
                    break;
                case Size.GRANDE:
                    extraCost = 1.10;
                    break;
                case Size.VENDI:
                    extraCost = 1.25;
                    break;
                default:
                    extraCost = 0.95;
                    break;
            }
            return extraCost + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Vanilla Sugar";
        }
    }
}