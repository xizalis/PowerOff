using PowerOff.Primitives;
using System;

namespace PowerOff
{
    // Format A3 - 297×420 мм

    public class A3
    {
        double height = 420;
        double width = 297;

        public void InitStartPoints(Scope scope)
        {
            double h2 = height / 2;
            double w2 = width / 2;

            scope.Points["A"] = new Point(-w2, +h2);
            scope.Points["B"] = new Point(+w2, +h2);
            scope.Points["C"] = new Point(+w2, -h2);
            scope.Points["D"] = new Point(-w2, -h2);
        }
    }
}
