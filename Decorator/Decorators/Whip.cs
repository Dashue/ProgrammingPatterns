namespace Decorator.Decorators
{
    public class Whip : CoffeeDecorator
    {
        public Whip(Coffee coffee)
            : base(coffee)
        {
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 0.7m;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + IngredientSeperator + "Whip";
        }
    }
}