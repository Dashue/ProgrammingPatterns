namespace DoubleDispatch
{
    public interface IDatabase
    {
        void Execute(IQuery db);
        void Read(ReadQuery read);
        void Write(WriteQuery read);
        void Delete(DeleteQuery read);
    }
}