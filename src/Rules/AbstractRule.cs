using System;

namespace PowerOff
{
    internal abstract class AbstractRule : IRule
    {
        #region Regex patterns
        protected string PointName = "[A-Za-z]{1,2}\\'?";
        protected string BigName = "[A-Za-z]{5,100}";
        #endregion

        protected IRule? nextRule;

        public void SetNext(IRule rule)
            => nextRule = rule;

        public abstract void Handle(string powerOffCode);
    }
}
