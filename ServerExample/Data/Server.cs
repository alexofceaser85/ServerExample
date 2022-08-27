using MySql.Data.MySqlClient;
using ServerExample.Model;
using System.Collections.Generic;

namespace ServerExample.Data
{
    public class Server
    {
        private static string connectionString = "server=localhost; port=3306; uid=root; pwd=0425; database=ship_visit;";

        public static List<Ship> GetShips()
        {
            var ships = new List<Ship>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from Ship";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        int nameOrdinal = reader.GetOrdinal("name");
                        int ownerOrdinal = reader.GetOrdinal("owner");

                        while (reader.Read())
                        {
                            string shipName = !reader.IsDBNull(nameOrdinal) ? reader.GetString(nameOrdinal) : null;
                            string shipOwner = !reader.IsDBNull(ownerOrdinal) ? reader.GetString(ownerOrdinal) : null;

                            ships.Add(new Ship(shipName, shipOwner));
                        }
                    }

                }
            }

            return ships;
        }

        public static void AddShip(string name, string owner)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"insert into Ship(name, owner) values ('{name}', '{owner}')";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void RemoveShip(string name)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"delete from Ship where name='{name}'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateShip(string newName, string oldName, string newOwner)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"update Ship set name='{newName}', owner='{newOwner}' where name='{oldName}'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

