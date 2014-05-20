using System;
using Xunit;

namespace Strategy
{
    public class StrategyTests
    {
        [Fact]
        public void Run()
        {
            Context context;
            context = new Context(new Add());
            var resultA = context.ExecuteStrategy(3, 4);

            context = new Context(new Subtract());
            var resultB = context.ExecuteStrategy(3, 4);

            context = new Context(new Multiply());
            var resultC = context.ExecuteStrategy(3, 4);

            Console.WriteLine("Result A : " + resultA);
            Console.WriteLine("Result B : " + resultB);
            Console.WriteLine("Result C : " + resultC);
        }
    }
}