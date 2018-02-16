using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DBConnection
{
    public abstract class DatabaseConn
    {
        public string connectionString { get; set; }
        public TimeSpan timeOut { get; }


        public DatabaseConn(String connectionString)
        {

            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                this.connectionString = connectionString;
                this.timeOut = TimeSpan.FromMilliseconds(1000);
            }
            else
            {
                throw new Exception("Invalid connection string");
            }


        }
       
        public abstract void ConnOpen();

        public abstract void ConnClose();



    }
}
