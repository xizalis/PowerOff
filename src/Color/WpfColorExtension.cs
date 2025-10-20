using System;
using System.Globalization;
using System.Text.RegularExpressions;

using HexColor = System.String;
using WpfColor = System.Windows.Media.Color;
using WpfBrush = System.Windows.Media.SolidColorBrush;

namespace PowerOff
{
    public static class WpfColorExtension
    {
        public static WpfColor ToWpfColor(this HexColor _this)
        {
            if (string.IsNullOrWhiteSpace(_this))
                throw new ArgumentNullException();
            var match = Regex.Match(_this, "^#?(?<hex>[0-9A-Fa-f]{3}|[0-9A-Fa-f]{6})$");
            if (!match.Success)
                throw new FormatException();
            string hex = match.Groups["hex"].Value;

            if (hex.Length == 3)
                hex = string.Concat(hex[0], hex[0], hex[1], hex[1], hex[2], hex[2]);
            byte r = byte.Parse(hex.Substring(0, 2), NumberStyles.AllowHexSpecifier);
            byte g = byte.Parse(hex.Substring(2, 2), NumberStyles.AllowHexSpecifier);
            byte b = byte.Parse(hex.Substring(4, 2), NumberStyles.AllowHexSpecifier);

            return WpfColor.FromRgb(r, g, b);
        }

        public static WpfBrush ToBrush(this WpfColor _this)
            => new WpfBrush(_this);
    }
}
