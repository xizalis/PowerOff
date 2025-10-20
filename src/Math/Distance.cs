using PowerOff.Primitives;
using System;
namespace PowerOff
{
    public static partial class Math
    {
        public static double Distance(Point a, Point b)
        {
            double dx = a.X - b.X;
            double dy = a.Y - b.Y;
            return System.Math.Sqrt(dx*dx + dy*dy);
        }
    }
}
