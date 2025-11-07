using PowerOff.Primitives;
using System;
using System.Text.RegularExpressions;

namespace PowerOff
{
    internal class ClonePoint : AbstractRule
    {
        public override void Handle(string request)
        {
            string pattern = $"^({PointName})=({PointName})$";
            var match = Regex.Match(request, pattern);
            if (match.Groups.Count == 0)
            {
                nextRule?.Handle(request);
                return;
            }

            //---

            string firstPointName = match.Groups[0].Value;
            string secondPointName = match.Groups[1].Value;

            Scope scope = new Scope();

            if (!scope.Points.Exist(secondPointName))
                return;

            Point secondPoint = scope.Points.Get(secondPointName);
            scope.Points.Set(firstPointName, secondPoint);
        }
    }
}