using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Stockontrol.DAO
{
    public class Database
    {
        private string connString = "Server=remotemysql.com;Database=uTrTPJ0nn1;Uid=uTrTPJ0nn1;Pwd=lc4PIqf8Ee";

        public string GetUsers()
        {
            var connection = new SqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM users";

                SqlDataReader reader = command.ExecuteReader();

                string users = "";
                while (reader.Read())
                {
                    users += ("ID: " + reader.GetString(0) + " | E-Mail: " + reader.GetString(1) + " | Senha: " + reader.GetString(2) + "/n");
                }

                Console.WriteLine(users);
                return users;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }

    }
}