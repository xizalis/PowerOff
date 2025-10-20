using System;

namespace PowerOff.Primitives
{
    public struct Line
    {
        public Point FirstPoint {  get; }
        public Point SecondPoint { get; }

        public Line(Point first, Point second)
        {
            FirstPoint = first;
            SecondPoint = second;
        }
    }
}
