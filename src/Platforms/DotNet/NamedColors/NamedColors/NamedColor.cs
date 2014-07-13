using System.Globalization;

namespace NamedColors
{
    public class NamedColor
    {
        public NamedColor(string name, string rgb)
        {
            Name = name;

            RGB = rgb;

            Red = byte.Parse(rgb.Substring(0, 2), NumberStyles.AllowHexSpecifier);
            Green = byte.Parse(rgb.Substring(2, 2), NumberStyles.AllowHexSpecifier);
            Blue = byte.Parse(rgb.Substring(4, 2), NumberStyles.AllowHexSpecifier);

        }

        public string Name { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
// ReSharper disable InconsistentNaming
        public string RGB { get; set; }
// ReSharper restore InconsistentNaming
    }
}
