using DbSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbSolution
{
    class Program
    {
        static void Main()
        {
            var sqlConnection = new SqlConnection("SQL_Connection_String");
            var command = new DbCommand(sqlConnection, "SELECT * FROM Users");
            command.Execute();

            var oracleConnection = new OracleConnection("Oracle_Connection_String");
            var oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Customers");
            oracleCommand.Execute();
        }
    }
}
