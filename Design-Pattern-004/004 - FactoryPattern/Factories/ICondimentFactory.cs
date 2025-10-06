using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factories
{
    internal interface ICondimentFactory
    {
        Beverage MakeAmericano(Beverage baseBeverage);
        Beverage MakeCappuccino(Beverage baseBeverage);
        Beverage MakeLatte(Beverage baseBeverage);
        Beverage MakeMocha(Beverage baseBeverage);
        Beverage MakeMacchiato(Beverage baseBeverage);
    }
}
