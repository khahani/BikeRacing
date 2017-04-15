namespace BikeRacingConsole
{
    public class Brake
    {
        public string Model { get; set; }

        private int _Power;
        public int Power
        {
            get
            {
                return _Power;
            }
            set
            {
                if (value > 10 || value <= 0)
                    throw new System.Exception("Brake Value is not Valid");

                _Power = value;
            }
        }
    }
}