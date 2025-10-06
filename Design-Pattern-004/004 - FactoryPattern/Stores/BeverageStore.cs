using DecoratorPattern.Beverages;
using DecoratorPattern.Factories;

namespace DecoratorPattern.Stores
{
    internal abstract class BeverageStore
    {
        public Beverage OrderDrink(DrinkType type, Size size = Size.GRANDE)
        {
            Beverage drink = CreateDrink(type);
            drink.Size = size;
            PrintBeverage(drink);
            return drink;
        }

        protected abstract Beverage CreateDrink(DrinkType type);
        void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) ${beverage.cost():#.##}");
        }
    }
}
