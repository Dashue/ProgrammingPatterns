namespace DoubleDispatch
{
    public interface IQuery
    {
        void Execute(IDatabase db);
    }
}