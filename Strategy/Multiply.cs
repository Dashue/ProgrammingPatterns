using System;

namespace Strategy
{
    public class Multiply : IStrategy
    {
        public decimal Execute(int a, int b)
        {
            Console.WriteLine("Called Multiply's execute()");
            return a * b;
        }
    }
}