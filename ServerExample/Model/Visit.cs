using System;

namespace ServerExample.Model
{
    public class Visit
    {
        public string shipName { get; set; }

        public string portName { get; set; }

        public string stateCountryCode { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public Visit(string shipName, string portName, string stateCountryCode, DateTime startDate, DateTime endDate)
        {
            this.shipName = shipName;
            this.portName = portName;
            this.stateCountryCode = stateCountryCode;
            this.startDate = startDate;
            this.endDate = endDate;
        }

    }
}
