using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private Amplifier _amplifier;
        private CdPlayer _cdPlayer;
        private DvdPlayer _dvdPlayer;
        private PopcornPopper _popcornPopper;
        private Projector _projector;
        private Screen _screen;
        private TheaterLights _theaterLights;
        private Tuner _tuner;

        public HomeTheaterFacade(Amplifier amplifier, CdPlayer cdPlayer, DvdPlayer dvdPlayer,
            PopcornPopper popcornPopper, Projector projector, Screen screen,
            TheaterLights theaterLights, Tuner tuner)
        {
            _amplifier = amplifier;
            _cdPlayer = cdPlayer;
            _dvdPlayer = dvdPlayer;
            _popcornPopper = popcornPopper;
            _projector = projector;
            _screen = screen;
            _theaterLights = theaterLights;
            _tuner = tuner;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Klaar om een film te kijken...");

            _popcornPopper.On();
            _popcornPopper.Pop();

            _theaterLights.Dim(10);

            _screen.Down();

            _projector.On();
            _projector.SetInput(_dvdPlayer);
            _projector.WideScreenMode();

            _amplifier.On();
            _amplifier.SetDvd(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);

            _dvdPlayer.On();
            _dvdPlayer.Play(movie);

            Console.WriteLine($"Nu aan het Afspelen: {movie}");
        }

        public void EndMovie()
        {
            Console.WriteLine("Film wordt afgesloten...");

            _dvdPlayer.Stop();
            _dvdPlayer.Off();

            _amplifier.Off();

            _projector.Off();

            _screen.Up();

            _theaterLights.On();

            _popcornPopper.Off();

            Console.WriteLine("De home theater is nu afgesloten.");
        }

        public void ListenToCd(string cd)
        {
            Console.WriteLine($"Klaar om naar {cd} te luisteren...");

            _amplifier.On();
            _amplifier.SetCd(_cdPlayer);
            _amplifier.SetStereoSound();
            _amplifier.SetVolume(3);

            _cdPlayer.On();
            _cdPlayer.Play();

            Console.WriteLine($"Nu aan het Afspelen: {cd}");
        }

        public void EndCd()
        {
            Console.WriteLine("CD speler wordt afgesloten...");

            _cdPlayer.Stop();
            _cdPlayer.Off();
            _amplifier.Off();

            Console.WriteLine("CD speler is nu afgesloten.");
        }

        public void ListenToRadio(string frequency)
        {
            Console.WriteLine($"Klaar om naar radio {frequency} te luisteren...");

            _tuner.On();
            _tuner.setFM();
            _tuner.setFrequency();

            _amplifier.On();
            _amplifier.SetTuner(_tuner);
            _amplifier.SetStereoSound();
            _amplifier.SetVolume(3);

            Console.WriteLine($"Nu aan het Afspelen: {frequency}");
        }

        public void EndRadio()
        {
            Console.WriteLine("Radio wordt afgesloten...");

            _tuner.Off();
            _amplifier.Off();

            Console.WriteLine("Radio is nu afgesloten.");
        }

        public void TurnOnAllDevices()
        {
            Console.WriteLine("Alle apparaten worden ingeschakeld...");

            _amplifier.On();
            _cdPlayer.On();
            _dvdPlayer.On();
            _popcornPopper.On();
            _projector.On();
            _theaterLights.On();
            _tuner.On();

            Console.WriteLine("Alle apparaten zijn nu ingeschakeld.");
        }

        public void TurnOffAllDevices()
        {
            Console.WriteLine("Alle apparaten worden uitgeschakeld...");

            _amplifier.Off();
            _cdPlayer.Off();
            _dvdPlayer.Off();
            _popcornPopper.Off();
            _projector.Off();
            _theaterLights.Off();
            _tuner.Off();

            Console.WriteLine("Alle apparaten zijn nu uitgeschakeld.");
        }
    }
}
