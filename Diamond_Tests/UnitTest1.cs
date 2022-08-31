using Diamond;

namespace Diamond_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestOneLine1()
        {
            // Diamond letter: E, Row Letter: C
            //Expected: "  C   C  "
            string actual = DrawDiamond.OneLine('E', 'C');
            string expected = "  C   C  ";
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('E', 'A', "    A    ")]
        [InlineData('E', 'B', "   B B   ")]
        [InlineData('E', 'C', "  C   C  ")]
        [InlineData('E', 'D', " D     D ")]
        [InlineData('E', 'E', "E       E")]
        [InlineData('C', 'A', "  A  ")]
        [InlineData('C', 'B', " B B ")]
        [InlineData('C', 'C', "C   C")]

        public void TestOneLine(char dletter, char rletter, string expected)
        {
            string actual = DrawDiamond.OneLine(dletter, rletter);
            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void TestPadding1()
        //{
        //    int actual = DrawDiamond.CalcPadding('E', 'C');
        //    int expected = 2;
        //    Assert.Equal(expected, actual);
        //}

        [Theory]
        [InlineData('E', 'A', 4)]
        [InlineData('E', 'B', 3)]
        [InlineData('E', 'C', 2)]
        [InlineData('E', 'D', 1)]
        [InlineData('E', 'E', 0)]
        [InlineData('C', 'A', 2)]
        [InlineData('C', 'B', 1)]
        [InlineData('C', 'C', 0)]

        public void TestPadding2(char dletter, char rletter, int expected)
        {
            int actual = DrawDiamond.CalcPadding(dletter, rletter);
            Assert.Equal(expected, actual);
        }
        [Fact]
        //spacing between letters on single line
        public void TestSpacing()
        {
            int actual = DrawDiamond.CalcSpacing('C');
            Assert.Equal(3, actual);
        }

        [Theory]
        [InlineData('A', 0)]    //1st part passing in, 2nd part expected
        [InlineData('B', 1)]
        [InlineData('C', 3)]
        [InlineData('D', 5)]
        [InlineData('Z', 49)]
        public void TestSpacing2(char rletter, int expected)
        {
            int actual = DrawDiamond.CalcSpacing(rletter);
            Assert.Equal(expected, actual);
        }

        //Create a single [Fact]
        [Fact]
        public void TestMakeSpaces()
        {
            string actual = DrawDiamond.MakeSpaces(3);
            string expected = "   ";
            Assert.Equal(expected, actual);
        }

        //Create a [Theory] with three [InLineData] lines
        [Theory]
        [InlineData(0, "")]
        [InlineData(1, " ")] //What we put in method, followed by expected back
        [InlineData(3, "   ")]
        [InlineData(5, "     ")]
        [InlineData(8, "        ")]

        public void TestMakeSpaces2(int num, string expected)
        {
            string actual = DrawDiamond.MakeSpaces(num);
            Assert.Equal(expected, actual);
        }
    }
}