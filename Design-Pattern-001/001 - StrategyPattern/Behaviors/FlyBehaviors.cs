using System;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I'm flying!");
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I can't fly.");
    }

    public class FlyWithRocket : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I'm flying with a rocket!");
    }

}
