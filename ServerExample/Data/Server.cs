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
                string query = "select * from ship";

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
    }
}

