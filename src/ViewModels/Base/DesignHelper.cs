using System;
using System.ComponentModel;
using System.Windows;

namespace PowerOff
{
    internal class DesignHelper
    {
        private static bool? isInDesignMode;

        public static bool IsInDesignMode
        {
            get
            {
                if (!isInDesignMode.HasValue)
                {
                    var prop = DesignerProperties.IsInDesignModeProperty;
                    isInDesignMode
                        = (bool)DependencyPropertyDescriptor
                            .FromProperty(prop, typeof(FrameworkElement))
                            .Metadata.DefaultValue;
                }
                return isInDesignMode.Value;
            }
        }
    }
}