
namespace Decorator
{
    public class SimpleCoffee : Coffee
    {
        public override decimal GetCost()
        {
            return 1;
        }

        public override string GetIngredients()
        {
            return "Coffee";
        }
    }
}
