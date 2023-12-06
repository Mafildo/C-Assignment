using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{

    public struct Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }
    }

    // Another class which contains method to calculate distance
    public class DistanceCalculator
    {
        public static float CalculateDistance(Point2D point1, Point2D point2)
        {
            float deltaX = point2.X - point1.X;
            float deltaY = point2.Y - point1.Y;

            float distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance;
        }
    }
}
