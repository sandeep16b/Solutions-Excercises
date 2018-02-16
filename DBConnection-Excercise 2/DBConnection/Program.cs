using System;
using System.Collections;
using System.Collections.Generic;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {


            var sqlCommand = "select * from sql_customers";
            var sqlConnString = "SQL username";
            var sqlConnection = new SqlConnection(sqlConnString);
            var dbCommand = new DBCommand(sqlConnection, sqlCommand);
            dbCommand.Execute();
   
            //Whitespace
            Console.WriteLine();

            var oracleCommand = "select * from oracle_customers";
            var oracleConnString = "Oracle username";
            var oracleConnection = new OracleConnection(oracleConnString);
            dbCommand = new DBCommand(oracleConnection, oracleCommand);
            dbCommand.Execute();


           
        }
    }
}
