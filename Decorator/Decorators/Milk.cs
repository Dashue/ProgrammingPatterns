namespace Decorator.Decorators
{
    public class Milk : CoffeeDecorator
    {
        public Milk(Coffee coffee)
            : base(coffee)
        {
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 0.5m;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + IngredientSeperator + "Milk";
        }
    }
}