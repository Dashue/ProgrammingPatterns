using System;
using Decorator.Decorators;
using Xunit;

namespace Decorator
{
    public class CoffeeTests
    {
        [Fact]
        public void CoffeeTest()
        {
            Coffee c = new SimpleCoffee();
            Console.WriteLine("Cost: " + c.GetCost() + "; Ingredients: " + c.GetIngredients());

            c = new Milk(c);
            Console.WriteLine("Cost: " + c.GetCost() + "; Ingredients: " + c.GetIngredients());

            c = new Sprinkles(c);
            Console.WriteLine("Cost: " + c.GetCost() + "; Ingredients: " + c.GetIngredients());

            c = new Whip(c);
            Console.WriteLine("Cost: " + c.GetCost() + "; Ingredients: " + c.GetIngredients());

            // Note that you can also stack more than one decorator of the same type
            c = new Sprinkles(c);
            Console.WriteLine("Cost: " + c.GetCost() + "; Ingredients: " + c.GetIngredients());
        }
    }
}