using System;

namespace DoubleDispatch
{
    public class ConsoleDatabase : IDatabase
    {
        public void Execute(IQuery query)
        {
            query.Execute(this);
        }

        public void Read(ReadQuery read)
        {
            Console.WriteLine("Reading " + read.Query);
        }

        public void Write(WriteQuery write)
        {
            Console.WriteLine("Writing");
        }

        public void Delete(DeleteQuery delete)
        {
            Console.WriteLine("Deleting");
        }
    }
}