using System;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Behaviors
{
    public class CanSwim : ISwimBehavior
    {
        public void Swim() => Console.WriteLine("I'm swimming!");
    }

    public class CantSwim : ISwimBehavior
    {
        public void Swim() => Console.WriteLine("I can't swim.");
    }
}
