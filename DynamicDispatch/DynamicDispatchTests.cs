using Xunit;

namespace DynamicDispatch
{
    public class DynamicDispatchTests
    {
        [Fact]
        public void Run()
        {
            var dispatcher = new Dispatcher();

            dispatcher.Dispatch(new A());
            dispatcher.Dispatch(new B());
            dispatcher.Dispatch(new C());
        }
    }
}