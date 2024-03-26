using System;
using Microsoft.AspNetCore.Hosting.Server;
using MySqlConnector;

namespace TP_ToDoList.Api.Database
{
	public class TodoDbConnection
	{
		private static MySqlConnection _connection;

		private TodoDbConnection()
		{

		}

        public static MySqlConnection GetInstance()
        {

            try
            {
                var connectionString = "server=localhost;port=3306;user=root;password=root;Database=Todo";
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connexion réussie");

                return connection;
            }
            catch (MySqlException sqlEx)
            {
                Console.WriteLine($"Erreur : {sqlEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
                throw;
            }

        }
    }
}

