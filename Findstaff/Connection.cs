using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Findstaff
{
    class Connection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlConnection dbConnection()
        {
            server = "localhost";
            database = "rms";
            uid = "root";
            password = "anterograde";
            //password = "rootpass";
            //password = "camilo";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
