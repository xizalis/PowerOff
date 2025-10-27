using System;

namespace PowerOff.Primitives
{
    public struct Circle
    {
        public Point CenterPoint { get; }
        public Point FirstPoint { get; }
        public Point SecondPoint { get; }

        public Circle(Point center, Point first, Point second)
        {
            CenterPoint = center;
            FirstPoint = first;
            SecondPoint = second;
            Radius = Math.Distance(FirstPoint, SecondPoint);
        }

        public Circle(Point center, Point second)
        {
            CenterPoint = center;
            FirstPoint = center;
            SecondPoint = second;
            Radius = Math.Distance(FirstPoint, SecondPoint);
        }

        public double Radius { get; private set; }
    }
}
