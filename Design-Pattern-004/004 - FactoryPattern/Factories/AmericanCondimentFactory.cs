using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factories
{
    internal class AmericanCondimentFactory : ICondimentFactory
    {
        public Beverage MakeAmericano(Beverage baseBeverage)
        {
            baseBeverage = new Water(baseBeverage);
            baseBeverage = new Water(baseBeverage);
            return baseBeverage;
        }

        public Beverage MakeCappuccino(Beverage baseBeverage)
        {
            baseBeverage = new SteamedMilk(baseBeverage);
            baseBeverage = new MilkFoam(baseBeverage);
            return new Whip(baseBeverage);
        }

        public Beverage MakeLatte(Beverage baseBeverage)
        {
            baseBeverage = new SteamedMilk(baseBeverage);
            baseBeverage = new SteamedMilk(baseBeverage);
            baseBeverage = new SteamedMilk(baseBeverage);
            return baseBeverage;
        }

        public Beverage MakeMocha(Beverage baseBeverage)
        {
            baseBeverage = new Chocolate(baseBeverage);
            baseBeverage = new SteamedMilk(baseBeverage);
            baseBeverage = new Whip(baseBeverage);
            return baseBeverage;
        }

        public Beverage MakeMacchiato(Beverage baseBeverage)
        {
            baseBeverage = new Syrup(baseBeverage);
            return new MilkFoam(baseBeverage);
        }
    }
}
