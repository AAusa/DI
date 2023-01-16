using System;
using MySql.Data.MySqlClient;
class Program
{
    static void Main(string[] args)
    {
        string connectionString =
        "Server=192.168.56.104;Database=biblioteca;Uid=miusuario;Pwd=Pass!123456; ";
    using (var connection = new
    MySqlConnection(connectionString))
        {
            connection.Open();
            // Consulta para obtener los nombres de los socios
            string query = "SELECT nombre FROM socio";
            using (var command = new MySqlCommand(query,
            connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["nombre"].ToString());
                    }
                }
            }
            connection.Close();
        }
    }
}