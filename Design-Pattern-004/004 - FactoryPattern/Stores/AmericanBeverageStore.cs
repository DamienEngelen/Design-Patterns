using DecoratorPattern.Beverages;
using DecoratorPattern.Factories;

namespace DecoratorPattern.Stores
{
    internal class AmericanBeverageStore : BeverageStore
    {
        private readonly ICondimentFactory factory = new AmericanCondimentFactory();

        protected override Beverage CreateDrink(DrinkType type)
        {
            Beverage baseEspresso = new Espresso();
            return type switch
            {
                DrinkType.Espresso => baseEspresso,
                DrinkType.Americano => factory.MakeAmericano(baseEspresso),
                DrinkType.Cappuccino => factory.MakeCappuccino(baseEspresso),
                DrinkType.Latte => factory.MakeLatte(baseEspresso),
                DrinkType.Mocha => factory.MakeMocha(baseEspresso),
                DrinkType.Macchiato => factory.MakeMacchiato(baseEspresso),
                _ => baseEspresso
            };
        }
    }
}
