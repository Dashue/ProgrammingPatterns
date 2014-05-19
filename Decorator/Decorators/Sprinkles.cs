namespace Decorator.Decorators
{
    public class Sprinkles : CoffeeDecorator
    {
        public Sprinkles(Coffee coffee)
            : base(coffee)
        {
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 0.2m;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + IngredientSeperator + "Sprinkles";
        }
    }
}