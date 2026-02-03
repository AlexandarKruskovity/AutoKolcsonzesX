using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKolcsozesX.DataBAseService
{
    internal class DataBAseService
    {
        private static string connectionString;
        private static string table;
        private static string query_parameterts;

        public static void DbConnectionCheck(string connectionString)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Sikeres adatbázis kapcsolat!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sikertelen csatlakozás");
                Console.WriteLine(ex);
            }
        }

    }
}