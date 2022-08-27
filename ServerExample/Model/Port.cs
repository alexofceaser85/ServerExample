namespace ServerExample.Model
{
    public class Port
    {
        public string portName { get; set; }

        public string stateCountryCode { get; set; }

        public Port(string portName, string stateCountryCode)
        {
            this.portName = portName;
            this.stateCountryCode = stateCountryCode;
        }
    }
}
