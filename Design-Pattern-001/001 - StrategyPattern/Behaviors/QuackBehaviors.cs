using System;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Behaviors
{
    public class QuackSound : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Quack!");
    }

    public class SqueakSound : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Squeak!");
    }

    public class Mute : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("<< Silence >>");
    }
}
