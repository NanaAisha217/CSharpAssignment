using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbSolution.Models
{
    public class DbCommand
    {
        private DbConnection _connection;
        private string _instruction;

        public DbCommand(DbConnection connection, string instruction)
        {
            _connection = connection ?? throw new ArgumentNullException("Connection cannot be null.");
            _instruction = !string.IsNullOrWhiteSpace(instruction) ? instruction : throw new ArgumentException("Instruction cannot be empty.");
        }

        public void Execute()
        {
            _connection.Open();
            Console.WriteLine("Executing command: " + _instruction);
            _connection.Close();
        }
    }
}
