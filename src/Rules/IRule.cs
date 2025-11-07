using System;

namespace PowerOff
{
    interface IRule
    {
        void SetNext(IRule rule);
        void Handle(string powerOffCode);
    }
}
