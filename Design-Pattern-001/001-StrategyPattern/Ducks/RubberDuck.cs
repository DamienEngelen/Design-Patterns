using System;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehaviors = new Mute();
            swimBehaviors = new CantSwim();
            flyBehaviors = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
            PerformQuack();
            PerformSwim();
            PerformFly();
        }
    }
}
