using System;
using System.Threading;
using System.Diagnostics;

namespace DBConnection
{
    public class SqlConnection : DatabaseConn
    {



        public SqlConnection(String connectionString) : base(connectionString)
        {
           
        }

        public override void ConnOpen()
        {
            var connectionStartTime = DateTime.Now;
            if (DateTime.Now - connectionStartTime > timeOut)
            {
                throw new TimeoutException("Connection TimeOut");
            }
                Console.WriteLine("SQL Connection opened");
         
        }

        public override void ConnClose()
        {
            Console.WriteLine("SQL Connection closed");
        }
    }
}
