using NamedColors;
using Xunit;

namespace Tests
{
    public class NamedColorShould
    {
        [Fact]
        public void CreateCorrectRgbString()
        {
            var sut = new NamedColor("x", 0,2,255);

            Assert.Equal("0002FF", sut.RGB);
        }

        [Fact]
        public void ShowNameForToString()
        {
            var sut = new NamedColor("Col", 0, 2, 255);

            Assert.Equal("Col", sut.ToString());
        }
    }
}
