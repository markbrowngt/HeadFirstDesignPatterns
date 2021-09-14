using System;

namespace StrategyPattern
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}