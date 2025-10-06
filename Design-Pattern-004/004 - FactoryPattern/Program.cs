using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Stores;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageStore italianStore = new ItalianBeverageStore();
            BeverageStore americanStore = new AmericanBeverageStore();

            Beverage itMocha = italianStore.OrderDrink(DrinkType.Mocha, Size.GRANDE);

            Beverage usLatte = americanStore.OrderDrink(DrinkType.Latte, Size.VENDI);

            Beverage espresso = new Espresso();
            espresso.Size = Size.GRANDE;

            Beverage doppio = new Espresso();
            doppio.Size = Size.GRANDE;
            doppio = new Espresso(doppio);

            Beverage lungo = new Espresso();
            lungo.Size = Size.TALL;
            lungo = new Lungo(lungo);

            Beverage macchiato = new Espresso();
            macchiato.Size = Size.VENDI;
            macchiato = new MilkFoam(macchiato);

            Beverage corretta = new Espresso();
            corretta = new Liqour(corretta);

            Beverage conPanna = new Espresso();
            conPanna.Size = Size.VENDI;
            conPanna = new Whip(conPanna);

            Beverage cappuccino = new Espresso();
            cappuccino.Size = Size.GRANDE;
            cappuccino = new SteamedMilk(cappuccino);
            cappuccino = new MilkFoam(cappuccino);

            Beverage americano = new Espresso();
            americano.Size = Size.VENDI;
            americano = new Water(americano);
            americano = new Water(americano);

            Beverage caffeLatte = new Espresso();
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);

            Beverage flatWhite = new Espresso();
            flatWhite.Size = Size.GRANDE;
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);

            Beverage romana = new Espresso();
            romana.Size = Size.VENDI;
            romana = new Lemon(romana);

            Beverage marocchino = new Espresso();
            marocchino = new Chocolate(marocchino);
            marocchino = new MilkFoam(marocchino);

            Beverage mocha = new Espresso();
            mocha.Size = Size.GRANDE;
            mocha = new Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);

            Beverage bicerin = new Espresso();
            bicerin.Size = Size.VENDI;
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);

            Beverage breve = new Espresso();
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);

            Beverage rafCoffee = new Espresso();
            rafCoffee.Size = Size.GRANDE;
            rafCoffee = new VanillaSugar(rafCoffee);
            rafCoffee = new Cream(rafCoffee);

            Beverage meadRaf = new Espresso();
            meadRaf.Size = Size.VENDI;
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);

            Beverage galao = new Espresso();
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);

            Beverage caffeAffogato = new Espresso();
            caffeAffogato.Size = Size.GRANDE;
            caffeAffogato = new IceCream(caffeAffogato);

            Beverage viennaCoffee = new Espresso();
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);

            Beverage glace = new Espresso();
            glace.Size = Size.GRANDE;
            glace = new IceCream(glace);

            Beverage chocolateMilk = new Chocolate();
            chocolateMilk.Size = Size.VENDI;
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);

            Beverage demiCreme = new Espresso();
            demiCreme = new Cream(demiCreme);

            Beverage latteMacchiato = new Espresso();
            latteMacchiato.Size = Size.GRANDE;
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);

            Beverage freddo = new Espresso();
            freddo.Size = Size.VENDI;
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);

            Beverage frappuccino = new Espresso();
            frappuccino.Size = Size.GRANDE;
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);

            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new Whip(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);

            Beverage frappe = new Espresso();
            frappe.Size = Size.VENDI;
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);

            Beverage irishCoffee = new Espresso();
            irishCoffee.Size = Size.VENDI;
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) ${beverage.cost():#.##}");
        }
    }
}
