namespace ServerExample.Model
{
    public class Ship
    {
        public string name { get; set; }

        public string owner { get; set; }

        public Ship(string name, string owner)
        {
            this.name = name;
            this.owner = owner;
        }
    }
}
