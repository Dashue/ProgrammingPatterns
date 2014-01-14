namespace DoubleDispatch
{
    public class ReadQuery : IQuery
    {
        public string Query { get; set; }

        public ReadQuery(string query)
        {
            Query = query;
        }

        public void Execute(IDatabase db)
        {
            db.Read(this);
        }
    }
}