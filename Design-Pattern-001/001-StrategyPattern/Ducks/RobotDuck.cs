using System;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Ducks
{
    internal class RobotDuck : Duck
    {
        public RobotDuck()
        {
            quackBehaviors = new Mute();
            swimBehaviors = new CantSwim();
            flyBehaviors = new FlyWithRocket();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck");
            PerformQuack();
            PerformSwim();
            PerformFly();
        }
    }
}
