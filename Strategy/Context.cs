
namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal ExecuteStrategy(int a, int b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
