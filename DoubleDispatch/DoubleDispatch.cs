
using Xunit;

namespace DoubleDispatch
{
    public class DoubleDispatch
    {
        [Fact]
        public void Run()
        {
            var db = new ConsoleDatabase();

            db.Execute(new ReadQuery("Customer"));
            db.Execute(new WriteQuery());
            db.Execute(new DeleteQuery());
        }
    }
}
