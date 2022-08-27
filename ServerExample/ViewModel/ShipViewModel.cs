using ServerExample.Data;
using System;
using ServerExample.Model;
using ServerExample.Model.managers;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ServerExample.Controller
{
    public class ShipController
    {
        private ShipManager shipManager;

        public ShipController()
        {
            this.shipManager = new ShipManager();
        }

        public List<Ship> GetShips()
        {
            return this.shipManager.GetShips();
        }

        public void AddShip(string name, string owner)
        {
            this.shipManager.AddShip(name, owner);
        }

        public void RemoveShip(string name)
        {
            this.shipManager.RemoveShip(name);
        }

        public void UpdateShip(string newName, string oldName, string newOwner)
        {
            this.shipManager.UpdateShip(newName, oldName, newOwner);
        }
    }
}
