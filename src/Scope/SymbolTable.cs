using PowerOff.Primitives;
using System;

namespace PowerOff
{
    public class SymbolTable<T> where T : struct
    {
        Dictionary<string, T> items = new();

        public void Set(string name, T value)
        {
            if (NotValid(name))
                return;
            if (items.ContainsKey(name))
                items[name] = value;
            else
                items.Add(name, value);
        }

        public T Get(string name)
        {
            if (NotValid(name))
                return default;
            if (items.ContainsKey(name))
                return items[name];
            return default;
        }

        public void Remove(string name)
        {
            if (NotValid(name))
                return;
            if (items.ContainsKey(name))
                items.Remove(name);
        }

        //---

        public T this[string name]
        {
            get => Get(name);
            set => Set(name, value);
        }

        //---

        bool NotValid(string name)
            => string.IsNullOrWhiteSpace(name);
    }
}
