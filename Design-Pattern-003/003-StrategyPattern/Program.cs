using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Espresso
            Beverage espresso = new Espresso();
            espresso.Size = Size.GRANDE;
            PrintBeverage(espresso);

            // Doppio
            Beverage doppio = new Espresso();
            doppio.Size = Size.GRANDE;
            doppio = new Espresso(doppio);
            PrintBeverage(doppio);

            // Lungo
            Beverage lungo = new Espresso();
            lungo.Size = Size.TALL;
            lungo = new Lungo(lungo);
            PrintBeverage(lungo);

            // Macchiato
            Beverage macchiato = new Espresso();
            macchiato.Size = Size.VENDI;
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            // Corretta
            Beverage corretta = new Espresso();
            corretta = new Liqour(corretta);
            PrintBeverage(corretta);

            // Con Panna
            Beverage conPanna = new Espresso();
            conPanna.Size = Size.VENDI;
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            // Cappuccino
            Beverage cappuccino = new Espresso();
            cappuccino.Size = Size.GRANDE;
            cappuccino = new SteamedMilk(cappuccino);
            cappuccino = new MilkFoam(cappuccino);
            PrintBeverage(cappuccino);

            // Americano
            Beverage americano = new Espresso();
            americano.Size = Size.VENDI;
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            // Caffé Latte
            Beverage caffeLatte = new Espresso();
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            PrintBeverage(caffeLatte);

            // Flat White
            Beverage flatWhite = new Espresso();
            flatWhite.Size = Size.GRANDE;
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            PrintBeverage(flatWhite);

            // Romana
            Beverage romana = new Espresso();
            romana.Size = Size.VENDI;
            romana = new Lemon(romana);
            PrintBeverage(romana);

            // Marocchino
            Beverage marocchino = new Espresso();
            marocchino = new Chocolate(marocchino);
            marocchino = new MilkFoam(marocchino);
            PrintBeverage(marocchino);

            // Mocha
            Beverage mocha = new Espresso();
            mocha.Size = Size.GRANDE;
            mocha = new Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            // Bicerin
            Beverage bicerin = new Espresso();
            bicerin.Size = Size.VENDI;
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            // Breve
            Beverage breve = new Espresso();
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage(breve);

            // Raf coffee
            Beverage rafCoffee = new Espresso();
            rafCoffee.Size = Size.GRANDE;
            rafCoffee = new VanillaSugar(rafCoffee);
            rafCoffee = new Cream(rafCoffee);
            PrintBeverage(rafCoffee);

            // Mead raf
            Beverage meadRaf = new Espresso();
            meadRaf.Size = Size.VENDI;
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);
            PrintBeverage(meadRaf);

            // Galao
            Beverage galao = new Espresso();
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            // Caffé affogato
            Beverage caffeAffogato = new Espresso();
            caffeAffogato.Size = Size.GRANDE;
            caffeAffogato = new IceCream(caffeAffogato);
            PrintBeverage(caffeAffogato);

            // Vienna coffee
            Beverage viennaCoffee = new Espresso();
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            PrintBeverage(viennaCoffee);

            // Glace
            Beverage glace = new Espresso();
            glace.Size = Size.GRANDE;
            glace = new IceCream(glace);
            PrintBeverage(glace);

            // Chocolate milk
            Beverage chocolateMilk = new Chocolate();
            chocolateMilk.Size = Size.VENDI;
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            PrintBeverage(chocolateMilk);

            // Demi – crème
            Beverage demiCreme = new Espresso();
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            // Latte macchiato
            Beverage latteMacchiato = new Espresso();
            latteMacchiato.Size = Size.GRANDE;
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            // Freddo
            Beverage freddo = new Espresso();
            freddo.Size = Size.VENDI;
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            // Frappuccino
            Beverage frappuccino = new Espresso();
            frappuccino.Size = Size.GRANDE;
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            // Caramel frappuccino
            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new Whip(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            // Frappe
            Beverage frappe = new Espresso();
            frappe.Size = Size.VENDI;
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);

            // Irish Coffee
            Beverage irishCoffee = new Espresso();
            irishCoffee.Size = Size.VENDI;
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) ${beverage.cost():#.##}");
        }
    }
}
