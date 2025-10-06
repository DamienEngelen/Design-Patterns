using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehaviors = new Behaviors.QuackSound();
            swimBehaviors = new Behaviors.CanSwim();
            flyBehaviors = new Behaviors.FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
            PerformQuack();
            PerformSwim();
            PerformFly();
        }
    }
}
