using PowerOff.Primitives;
using System;

namespace PowerOff
{
    public static partial class Math
    {
        public static Point Avg(Point p1, Point p2)
        {
            double x = (p1.X + p2.X) / 2;
            double y = (p1.Y + p2.Y) / 2;
            return new Point(x, y);
        }

        public static Point Avg(params Point[] points)
        {
            double x = 0;
            double y = 0;
            for (int i = 0; i < points.Length; i++)
            {
                x += points[i].X;
                y += points[i].Y;
            }
            x /= points.Length;
            y /= points.Length;
            return new Point(x, y);
        }
    }
}
