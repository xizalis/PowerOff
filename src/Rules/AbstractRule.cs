using System;

namespace PowerOff
{
    internal abstract class AbstractRule : IRule
    { 
        protected IRule? nextRule;

        public void SetNext(IRule rule)
            => nextRule = rule;

        public abstract void Handle(string powerOffCode);
    }
}
