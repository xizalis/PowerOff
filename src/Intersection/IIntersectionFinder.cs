using PowerOff.Primitives;
using System;

namespace PowerOff
{
    interface IIntersectionFinder
    {
        (Point, Point) Intersect(Line l, Circle c);

        (Point, Point) Intersect(Circle c1, Circle c2);

        Point Intersect(Line l1, Line l2);
    }
}
