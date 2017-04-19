using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRacingConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bike bike = new Bike
            {
                Name = "Gitane",
                Brake = new Brake { Model = "2017", Power = 3 },
                Gear = new Gear { Model = "2016", Size = 8 }
            };

            Ciclist khahani = new Ciclist(bike);
            khahani.Name = "Khahani";
            khahani.PushPower = 5;
            khahani.RoundPerMinutes = 10;
            Ciclist mohammadi = new Ciclist(bike);
            mohammadi.Name = "M";
            mohammadi.PushPower = 3;
            mohammadi.RoundPerMinutes = 5;
            Ciclist saeed = new Ciclist(bike);
            saeed.Name = "Saeed";
            saeed.PushPower = 10;
            saeed.RoundPerMinutes = 10;

            Map map = new Map();
            map.AddPoint(new Point() { Name = "p1", Type = PointType.Straight, Length = 1000, MaxSpeed = 100 });
            map.AddPoint(new Point() { Name = "p2", Type = PointType.Turn, Length = 20, MaxSpeed = 20 });
            map.AddPoint(new Point() { Name = "p3", Type = PointType.Straight, Length = 1000, MaxSpeed = 100 });
            map.AddPoint(new Point() { Name = "p4", Type = PointType.Turn, Length = 100, MaxSpeed = 50 });

            Competition c1 = new Competition();
            c1.Map = map;

            khahani.RegisterOnCompetition(c1);
            mohammadi.RegisterOnCompetition(c1);
            saeed.RegisterOnCompetition(c1);

            c1.Start();

            Console.ReadKey();

        }
    }
}
