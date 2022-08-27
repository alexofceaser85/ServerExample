using ServerExample.Data;
using ServerExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerExample.Controller;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace ServerExample
{
    public partial class Ships : Form
    {
        public ShipController shipController;

        public Ships()
        {
            shipController = new ShipController();
            InitializeComponent();
            updateShipList();
        }

        private void updateShipList()
        {
            shipList.Items.Clear();
            var ships = shipController.GetShips();

            foreach (Ship ship in ships)
            {
                shipList.Items.Add($"{ship.name} Owned By: {ship.owner}");
            }
        }

        private void addShipButton_Click(object sender, EventArgs e)
        {
            this.shipController.AddShip(shipNameTextInput.Text, shipOwnerTextInput.Text);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.updateShipList();
        }

        private void removeShip_Click(object sender, EventArgs e)
        {
            this.shipController.RemoveShip(removeShipTextInput.Text);
        }

        private void shipList_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeShipTextInput.Text = shipController.GetShips()[shipList.SelectedIndex].name;
            modifyOldShipNameTextInput.Text = shipController.GetShips()[shipList.SelectedIndex].name;
            modifyNewShipNameTextInput.Text = shipController.GetShips()[shipList.SelectedIndex].name;
            modifyNewShipOwnerTextInput.Text = shipController.GetShips()[shipList.SelectedIndex].owner;
        }

        private void modifyShipButton_Click(object sender, EventArgs e)
        {
            this.shipController.UpdateShip(modifyNewShipNameTextInput.Text, modifyOldShipNameTextInput.Text, modifyNewShipOwnerTextInput.Text);
        }
    }
}
