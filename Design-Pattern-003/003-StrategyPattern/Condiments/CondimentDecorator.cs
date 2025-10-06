using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal abstract class CondimentDecorator : Beverage
    {
        protected CondimentDecorator(Beverage beverage)
        {
            this.baseBeverage = beverage ?? throw new ArgumentNullException(nameof(beverage));
            this.Size = beverage.Size;
        }

        public abstract override string GetDescription();
    }
}
