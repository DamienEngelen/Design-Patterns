namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create all the individual components
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                amp, cdPlayer, dvdPlayer, popcornPopper,
                projector, screen, lights, tuner);

            Console.WriteLine("=== Damien's Film Theater ===\n");

            Console.WriteLine("1. Bezig met het aanzetten van alle apparaten:");
            homeTheater.TurnOnAllDevices();

            Console.WriteLine("\nWachten...\n");

            Console.WriteLine("2. Bezig met het starten van de filmervaring:");
            homeTheater.WatchMovie("Die Hard");

            Console.WriteLine("\nFilm wordt afgespeeld...\n");

            Console.WriteLine("3. Bezig met het afsluiten van de film:");
            homeTheater.EndMovie();

            Console.WriteLine("\nWachten...\n");

            Console.WriteLine("4. Bezig met het afspelen van de CD:");
            homeTheater.ListenToCd("Greatest Hits");

            Console.WriteLine("\nLuisteren naar muziek...\n");

            Console.WriteLine("5. Bezig met het stoppen van de CD:");
            homeTheater.EndCd();

            Console.WriteLine("\nWachten...\n");

            Console.WriteLine("6. Bezig met het afspelen van de radio:");
            homeTheater.ListenToRadio("101.5 FM");

            Console.WriteLine("\nLuisteren naar de radio...\n");

            Console.WriteLine("7. Bezig met het stoppen van de radio:");
            homeTheater.EndRadio();

            Console.WriteLine("\nWachten...\n");

            Console.WriteLine("8. Bezig met het uitschakelen van alle apparaten:");
            homeTheater.TurnOffAllDevices();
        }
    }
}
