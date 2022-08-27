namespace ServerExample.Model
{
    public class StateCountry
    {
        public string code { get; set; }

        public string state { get; set; }

        public string country { get; set; }

        public StateCountry(string code, string state, string country)
        {
            this.code = code;
            this.state = state;
            this.country = country;
        }

    }
}
