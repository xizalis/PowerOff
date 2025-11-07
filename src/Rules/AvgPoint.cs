using PowerOff.Primitives;
using System;
using System.Text.RegularExpressions;

namespace PowerOff
{
    internal class AvgPoint : AbstractRule
    {
        public override void Handle(string request)
        {
            string pattern = $"^({PointName})=({PointName}),({PointName})$";
            var match = Regex.Match(request, pattern);
            if (match.Groups.Count == 0)
            {
                nextRule?.Handle(request);
                return;
            }

            //---

            string firstPointName = match.Groups[0].Value;
            string secondPointName = match.Groups[1].Value;
            string thirdPointName = match.Groups[2].Value;

            //---

            Scope scope = new Scope();

            if (!scope.Points.Exist(secondPointName))
                return;
            if (!scope.Points.Exist(thirdPointName))
                return;

            Point secondPoint = scope.Points.Get(secondPointName);
            Point thirdPoint = scope.Points.Get(thirdPointName);
            Point firstPoint = Math.Avg(secondPoint, thirdPoint);

            scope.Points.Set(firstPointName, firstPoint);
        }
    }
}