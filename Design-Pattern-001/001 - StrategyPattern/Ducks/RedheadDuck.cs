using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehaviors = new Behaviors.QuackSound();
            swimBehaviors = new Behaviors.CanSwim();
            flyBehaviors = new Behaviors.FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck");
            PerformQuack();
            PerformSwim();
            PerformFly();
        }
    }
}
