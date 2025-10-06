using System;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Ducks
{
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            quackBehaviors = new Mute();
            swimBehaviors = new CantSwim();
            flyBehaviors = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck");
            PerformQuack();
            PerformSwim();
            PerformFly();
        }
    }
}
