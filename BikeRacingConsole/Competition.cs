using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRacingConsole
{
    public class Competition
    {
        public DateTime BeginAt { get; set; }
        public Map Map { get; set; }

        private List<Ciclist> Participants;

        public Competition()
        {
            Participants = new List<Ciclist>();
        }

        public void Start()
        {
            BeginAt = DateTime.Now.AddSeconds(10);
            foreach (Ciclist ciclist in Participants)
            {
                ciclist.Ready(BeginAt.TimeOfDay);
            }
        }

        public void Register(Ciclist ciclist)
        {
            Participants.Add(ciclist);
        }
    }
}
