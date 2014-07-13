using NamedColors;
using Xunit;

namespace Tests
{
    public class NamedColorShould
    {
        [Fact]
        public void CreateCorrectIndividualRgbValues()
        {
            var sut = new NamedColor("x", "010203");

            Assert.Equal(1, sut.Red);
            Assert.Equal(2, sut.Green);
            Assert.Equal(3, sut.Blue);
        }
    }
}
