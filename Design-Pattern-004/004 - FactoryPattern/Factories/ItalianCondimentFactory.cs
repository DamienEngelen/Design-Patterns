using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factories
{
    internal class ItalianCondimentFactory : ICondimentFactory
    {
        public Beverage MakeAmericano(Beverage baseBeverage)
        {
            baseBeverage = new Water(baseBeverage);
            return new Water(baseBeverage);
        }

        public Beverage MakeCappuccino(Beverage baseBeverage)
        {
            baseBeverage = new SteamedMilk(baseBeverage);
            return new MilkFoam(baseBeverage);
        }

        public Beverage MakeLatte(Beverage baseBeverage)
        {
            baseBeverage = new SteamedMilk(baseBeverage);
            baseBeverage = new SteamedMilk(baseBeverage);
            return new MilkFoam(baseBeverage);
        }

        public Beverage MakeMocha(Beverage baseBeverage)
        {
            baseBeverage = new Chocolate(baseBeverage);
            baseBeverage = new SteamedMilk(baseBeverage);
            return new Whip(baseBeverage);
        }

        public Beverage MakeMacchiato(Beverage baseBeverage)
        {
            return new MilkFoam(baseBeverage);
        }
    }
}
