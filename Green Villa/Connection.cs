using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace Green_Villa
{
    public class Connection
    {
        private string connectionString;

        private string server = "localhost";
        private string database = "greenvilla";
        private string username = "root";
        private string password = "";

        MySqlConnection con;  // define a MySqlConnection object named con

        public Connection()    // constructor
        {
            connectionString = $"Server={server};Database={database};User={username};Password={password};";
            con = new MySqlConnection(connectionString); // create the connection and assign it to 'con'
        }

        public void Open()   // open a connection
        {
            // ConnectionState is the state of the connection to the current data source
            // ConnectionState.Closed = 1 when closed
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void Close()   // close a connection
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // create sql command using the given query
        public MySqlCommand CreateCommand(string query)   // return type is 'MySqlCommand'
        {
            return new MySqlCommand(query, con);
        }

        // execute sql commands that doesn't return a value (insert,delete,update)
        public void ExecuteNonQuery(string query)
        {
            //using() disposes of the command object at the end of the scope 
            using (var command = CreateCommand(query))    // creates a a command using CreateCommand() defined above
            {
                Open();
                command.ExecuteNonQuery();
            }
        }

        // execute sql commands that return a value (read)
        public MySqlDataReader ExecuteReader(string query) // return type is MySqlDataReader
        {
            var command = CreateCommand(query);
            Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior gives the results of the command
                                                                           // CloseConnection automatically closes the connection
        }
    }
}