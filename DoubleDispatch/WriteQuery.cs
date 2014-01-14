namespace DoubleDispatch
{
    public class WriteQuery : IQuery
    {
        public void Execute(IDatabase db)
        {
            db.Write(this);
        }
    }
}