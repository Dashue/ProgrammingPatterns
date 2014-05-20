using System;

namespace Strategy
{
    public class Add : IStrategy
    {
        public decimal Execute(int a, int b)
        {
            Console.WriteLine("Called Add's execute()");
            return a + b;
        }
    }
}