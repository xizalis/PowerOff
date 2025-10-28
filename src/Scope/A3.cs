using PowerOff.Primitives;
using System;

namespace PowerOff
{
    public class A3
    {
        public void InitStartPoints(Scope scope)
        {
            Page A3 = new Page(297, 420);
            InitStartPoints(scope, A3);
        }

        public void InitStartPoints(Scope scope, Page page)
        {
            double h2 = page.Height / 2;
            double w2 = page.Width / 2;

            scope.Points["A"] = new Point(-w2, +h2);
            scope.Points["B"] = new Point(+w2, +h2);
            scope.Points["C"] = new Point(+w2, -h2);
            scope.Points["D"] = new Point(-w2, -h2);
        }
    }
}
