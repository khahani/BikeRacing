using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRacingConsole
{
    public class Bike
    {
        public string Name { get; set; }
        public Gear Gear { get; set; }
        public Brake Brake { get; set; }

        private int _Speed;
        public int Speed
        {
            get
            {
                return _Speed;
            }
            private set
            {
                if (value <= 0)
                    _Speed = 0;
                else
                    _Speed = value;
            }
        }

        /// <summary>
        /// Use pedal when want to raise bike speed.
        /// </summary>
        /// <param name="rpm">Round Per Minutes</param>
        public void Pedal(int rpm)
        {
            Speed = Gear.Size * rpm;
        }

        public void Braking(int push)
        {
            Speed -= Brake.Power * push;
        }
    }
}
