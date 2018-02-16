using System;
namespace DBConnection
{
    public class DBCommand 
     {

        private readonly DatabaseConn _dbConnection;
        private readonly string _instruction;

        public DBCommand(DatabaseConn dbConnection, String instruction)
        {
            if (String.IsNullOrWhiteSpace(dbConnection.ToString()))
            {
                throw new ArgumentNullException(nameof(dbConnection));
            }
            if (String.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentNullException(nameof(instruction));
            }
            this._dbConnection = dbConnection;
            this._instruction = instruction;
        }

        public void Execute(){
            _dbConnection.ConnOpen();
            RunInstruction();
            _dbConnection.ConnOpen();
        }

        public void RunInstruction(){
            Console.WriteLine("Running instruction " + _instruction);
        }

    }
}
