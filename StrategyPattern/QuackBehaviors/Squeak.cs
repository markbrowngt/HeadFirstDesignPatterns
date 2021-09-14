using System;

namespace StrategyPattern
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}