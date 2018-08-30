using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjetAeroport.Models
{
    public static class Database
    {
        private static SqlConnection connection = null;

        public static SqlConnection GetConnection() {
            try
            {
                connection = new SqlConnection(Config.connectionString);
                connection.Open();

            }catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
            return connection;
        }

        public static void Close() {
            connection.Close();
        }
    }
}