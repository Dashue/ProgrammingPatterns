namespace DoubleDispatch
{
    public class DeleteQuery : IQuery
    {
        public void Execute(IDatabase db)
        {
            db.Delete(this);
        }
    }
}