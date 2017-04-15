namespace BikeRacingConsole
{
    public class Gear
    {
        public string Model { get; set; }
        private int _Size;

        public int Size
        {
            get
            { return _Size; }
            set
            {
                if (value > 10 || value <= 0)
                    throw new System.Exception("Gear size is not valid");
                _Size = value;
            }
        }
    }
}