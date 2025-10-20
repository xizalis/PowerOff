using System;
using WpfColor = System.Windows.Media.Color;
using HexColor = System.String;

namespace PowerOff
{
    public static class PowerOffColorExtension
    {
        public static HexColor ToHexColor(this PowerOffColor _this)
        {
            switch (_this)
            {
                case PowerOffColor.Paper:
                    return "#800000";
                case PowerOffColor.Graphiite:
                default:
                    return "#008000";
                case PowerOffColor.Silver:
                    return "#000080";
                case PowerOffColor.Cooper:
                    return "#400040";
                case PowerOffColor.Bronse:
                    return "#404000";
                case PowerOffColor.Gold:
                    return "#004040";
            }
        }
        public static WpfColor ToWpfColor(this PowerOffColor _this)
        {
            return _this.ToHexColor().ToWpfColor();
        }
    }
}
