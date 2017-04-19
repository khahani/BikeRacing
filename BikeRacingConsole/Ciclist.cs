using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BikeRacingConsole
{
    public class Ciclist
    {
        public Ciclist(Bike bike)
        {
            Bike = bike;
        }

        public string Name { get; set; }
        public int RoundPerMinutes { get; set; }
        public int PushPower { get; set; }

        private Bike Bike { get; set; }

        public int Speed { get { return Bike.Speed; } }

        public void Pedal()
        {
            if (Bike == null)
            {
                throw new Exception("There is no bike to ride!");
            }

            Bike.Pedal(RoundPerMinutes);
        }

        private System.Threading.Timer timer;
        public void Ready(TimeSpan beginAt)
        {
            if (_RegisterdCompetition == null)
            {
                throw new Exception(Name + " does not register on the competition.");
            }

            Console.WriteLine(Name + " getting ready.");

            DateTime current = DateTime.Now;
            TimeSpan timeToGo = beginAt - current.TimeOfDay;
            if (timeToGo < TimeSpan.Zero)
            {
                return;//time already passed
            }
            this.timer = new Timer(x =>
            {
                this.Go();
            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }

        private void Go()
        {
            List<Point> direction = _RegisterdCompetition.Map.GetDirection();

            foreach (Point point in _RegisterdCompetition.Map.GetDirection())
            {
                if (point.Type == PointType.Straight)
                {
                    Pedal();

                    Thread.Sleep(point.Length / Speed * 1000);
                }
                else
                {
                    while (Speed > point.MaxSpeed)
                    {
                        Breaking();
                    }

                    Thread.Sleep(point.Length / Speed * 1000);
                }

                Console.WriteLine(Name + " passed " + point.Name + " at " + DateTime.Now.ToLongTimeString());
            }
        }


        public void Breaking()
        {
            if (Bike == null)
            {
                throw new Exception("There is no bike to ride!");
            }

            Bike.Braking(PushPower);
        }

        private Competition _RegisterdCompetition;

        public void RegisterOnCompetition(Competition competition)
        {
            _RegisterdCompetition = competition;
            competition.Register(this);
        }
    }
}
