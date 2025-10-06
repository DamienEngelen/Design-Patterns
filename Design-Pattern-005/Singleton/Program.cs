namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            var boiler = ChocolateBoiler.Instance;
            boiler.Fill();
            boiler.Boil();
            boiler.Drain();
        }   
    }
}