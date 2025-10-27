using PowerOff.Primitives;
using System;

namespace PowerOff
{
    public static class AnalyticGeometry
    {
        public static (Point, Point) Intersect(Circle c1, Circle c2)
        {
            var d = Math.Distance(c1.CenterPoint, c2.CenterPoint);
            if (d > c1.Radius + c2.Radius)
                return new(default, default);
            if (d < System.Math.Abs(c1.Radius + c2.Radius))
                return new(default, default);
            if (d == 0 && c1.Radius == c2.Radius)
                return new(default, default);

            double a = (c1.Radius * c1.Radius - c2.Radius * c2.Radius + d * d) / (2 * d);
            double h = System.Math.Sqrt(c1.Radius * c1.Radius - a * a);

            double x0 = c1.CenterPoint.X;
            double y0 = c1.CenterPoint.Y;
            double x1 = c2.CenterPoint.X;
            double y1 = c2.CenterPoint.Y;

            double x2 = x0 + a * (x1 - x0) / d;
            double y2 = y0 + a * (y1 - y0) / d;

            double rx = -(y1 - y0) * (h / d);
            double ry = (x1 - x0) * (h / d);

            Point p1 = new Point(x2 + rx, y2 + ry);
            Point p2 = new Point(x2 - rx, y2 - ry);

            return (p1, p2);
        }

        public static (Point, Point) Intersect(Line l, Circle c)
        {
            double dx = l.SecondPoint.X - l.FirstPoint.X;
            double dy = l.SecondPoint.Y - l.FirstPoint.Y;

            double fx = l.FirstPoint.X - c.CenterPoint.X;
            double fy = l.FirstPoint.Y - c.CenterPoint.Y;

            double a = dx * dx + dy * dy;
            double b = 2 * (fx * dx + fy * dy);
            double cVal = fx * fx + fy * fy - c.Radius * c.Radius;

            double discriminant = b * b - 4 * a * cVal;

            if (discriminant < 0)
                return (default, default);

            discriminant = System.Math.Sqrt(discriminant);

            double t1 = (-b + discriminant) / (2 * a);
            double t2 = (-b - discriminant) / (2 * a);

            Point i1 = new Point(l.FirstPoint.X + t1 * dx, l.FirstPoint.Y + t1 * dy);
            Point i2 = new Point(l.FirstPoint.X + t2 * dx, l.FirstPoint.Y + t2 * dy);

            return (i1, i2);
        }

        public static Point Intersect(Line l1, Line l2)
        {
            double A1 = l1.SecondPoint.Y - l1.FirstPoint.Y;
            double B1 = l1.FirstPoint.X - l1.SecondPoint.X;
            double C1 = A1 * l1.FirstPoint.X + B1 * l1.FirstPoint.Y;

            double A2 = l2.SecondPoint.Y - l2.FirstPoint.Y;
            double B2 = l2.FirstPoint.X - l2.SecondPoint.X;
            double C2 = A2 * l2.FirstPoint.X + B2 * l2.FirstPoint.Y;

            double det = A1 * B2 - A2 * B1;

            if (System.Math.Abs(det) < 1e-10)
                return default;

            double x = (B2 * C1 - B1 * C2) / det;
            double y = (A1 * C2 - A2 * C1) / det;

            return new Point(x, y);
        }
    }
}
