using PowerOff.Primitives;
using System;

namespace PowerOff
{
    // Format A3 - 297×420 мм

    public class A3
    {
        double height = 420;
        double width = 297;

        public void InitABCD()
        {
            double h2 = height / 2;
            double w2 = width / 2;

            Point A = new Point(-w2, +h2);
            Point B = new Point(+w2, +h2);
            Point C = new Point(+w2, -h2);
            Point D = new Point(-w2, -h2);

            //TODO - Add A B C D to Scope
        }
    }
}
