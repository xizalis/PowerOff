using PowerOff.Primitives;
using System;

namespace PowerOff
{
    public class IntersectionFinder : IIntersectionFinder
    {
        public (Point, Point) Intersect(Line l, Circle c)
            => AnalyticGeometry.Intersect(l, c);

        public (Point, Point) Intersect(Circle c1, Circle c2)
            => AnalyticGeometry.Intersect(c1, c2);

        public Point Intersect(Line l1, Line l2)
            => AnalyticGeometry.Intersect(l1, l2);
    }
}
