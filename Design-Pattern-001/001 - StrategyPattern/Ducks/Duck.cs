using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        protected IFlyBehavior? flyBehaviors;
        protected IQuackBehavior? quackBehaviors;
        protected ISwimBehavior? swimBehaviors;

        public abstract void Display();

        public void PerformQuack()
        {
            quackBehaviors?.Quack();
        }

        public void PerformFly()
        {
            flyBehaviors?.Fly();
        }

        public void PerformSwim()
        {
            swimBehaviors?.Swim();
        }
    }
}
