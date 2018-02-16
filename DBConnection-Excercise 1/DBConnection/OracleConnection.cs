using System;
using System.Collections;
using System.Diagnostics;

namespace DBConnection
{
    public class OracleConnection : DatabaseConn
    {

       

        public OracleConnection(String connectionString) : base(connectionString)
        {
           
        }

        public override void ConnOpen()
        {
            
            var connectionStartTime = DateTime.Now;
            if (DateTime.Now - connectionStartTime > timeOut)
            {
                throw new TimeoutException("Connection TimeOut");
            }
            Console.WriteLine("Oracle Connection opened");
        }

        public override void ConnClose()
        {
            Console.WriteLine("Oracle Connection closed");
        }
    }
}
