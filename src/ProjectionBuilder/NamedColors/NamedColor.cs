using System.Globalization;

namespace NamedColors
{
    public class NamedColor
    {
        public NamedColor(string name, byte red, byte green, byte blue)
        {
            Name = name;

            RGB = red.ToString("X2") + green.ToString("X2") + blue.ToString("X2");

            Red = red;
            Green = green;
            Blue = blue;
        }

        public string Name { get; private set; }
        public byte Red { get; private set; }
        public byte Green { get; private set; }
        public byte Blue { get; private set; }
// ReSharper disable InconsistentNaming
        public string RGB { get; private set; }
// ReSharper restore InconsistentNaming

        public override string ToString()
        {
            return Name;
        }
    }
}
