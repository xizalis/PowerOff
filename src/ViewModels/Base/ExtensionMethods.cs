using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PowerOff
{
    public static class ExtensionMethods
    {
        public static ObservableCollection<T> ToVM<T>(this List<T> list)
            => new ObservableCollection<T>(list);
    }
}
