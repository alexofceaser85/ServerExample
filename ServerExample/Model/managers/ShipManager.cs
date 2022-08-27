using ServerExample.Data;
using System.Collections.Generic;

namespace ServerExample.Model.managers
{
    public class ShipManager
    {
        private List<Ship> ships;

        public ShipManager()
        {
            this.ships = new List<Ship>();
        }

        public List<Ship> GetShips()
        {
            return Server.GetShips();
        }

        public void AddShip(string name, string owner)
        {
            Server.AddShip(name, owner);
        }

        public void RemoveShip(string name)
        {
            Server.RemoveShip(name);
        }

        public void UpdateShip(string newName, string oldName, string newOwner)
        {
            Server.UpdateShip(newName, oldName, newOwner);
        }
    }
}
