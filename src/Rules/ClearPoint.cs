using PowerOff.Primitives;
using System;
using System.Text.RegularExpressions;

namespace PowerOff
{
    internal class ClearPoint : AbstractRule
    {
        public override void Handle(string request)
        {
            string PointName = @"^[A-Za-z]{1,3}\'{0,3}$";
            string pattern = $"({PointName})=_";

            var match = Regex.Match(request, pattern);
            if (match.Groups.Count == 0)
            {
                nextRule?.Handle(request);
                return;
            }

            //---

            string firstPointName = match.Groups[0].Value;

            //---

            Scope scope = new Scope();

            if (scope.Points.Exist(firstPointName))
                scope.Points.Remove(firstPointName);
        }
    }
}
