using System;
using System.Collections;
using System.Collections.Generic;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var sqlConnection = new SqlConnection("SQL username" );

            //To test the exception for the null connection string.

            //var sqlConnection = new SqlConnection("");
           

            sqlConnection.ConnOpen();
            sqlConnection.ConnClose();



            //Whitespace
            Console.WriteLine();

            var oracleConnection = new OracleConnection("Oracle username");

            //To test the exception for the null connection string.
            //var sqlConnection = new OracleConnection(" ");

            oracleConnection.ConnOpen();
            oracleConnection.ConnClose();


        }
    }
}
