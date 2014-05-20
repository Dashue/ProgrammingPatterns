using System;

namespace Strategy
{
    public class Subtract : IStrategy
    {
        public decimal Execute(int a, int b)
        {
            Console.WriteLine("Called Subtract's execute()");
            return a - b;
        }
    }
}