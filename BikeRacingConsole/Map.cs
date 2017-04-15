using System.Collections.Generic;

namespace BikeRacingConsole
{
    public class Map
    {
        private List<Point> Direction { get; set; }

        public Map()
        {
            Direction = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            Direction.Add(point);
        }

        public void AddRangePoint(IEnumerable<Point> points)
        {
            Direction.AddRange(points);
        }

        public List<Point> GetDirection()
        {
            return Direction;
        }
    }

    public class Point
    {
        public string Name { get; set; }
        public PointType Type { get; set; }
        public int Length { get; set; }
        public int MaxSpeed { get; set; }
    }

    public enum PointType
    {
        Turn,
        Straight
    } 

}