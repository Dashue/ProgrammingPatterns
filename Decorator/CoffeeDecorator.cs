namespace Decorator
{
    public abstract class CoffeeDecorator : Coffee
    {
        private Coffee _decoratedCoffee;
        protected const string IngredientSeperator = ", ";

        public CoffeeDecorator(Coffee coffee)
        {
            _decoratedCoffee = coffee;
        }

        public override decimal GetCost()
        {
            return _decoratedCoffee.GetCost();
        }

        public override string GetIngredients()
        {
            return _decoratedCoffee.GetIngredients();
        }
    }
}