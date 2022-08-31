using CalcApp;

namespace CalcApp_Tests
{
    public class UnitTest1
    {
        //Test the constructor first!
        [Fact]
        public void TestConstructor()
        {
            Calculator c1 = new Calculator(15);
            Assert.Equal(15, c1.Number);
            //int actual = c1.Number;
            //Assert.Equal(15, actual);
            //Same thing
        }

        //[Fact]
        //public void TestFindFactorial()
        //{
        //    // Test factorial of 4, which is 24
        //    //Making instance of class then calling function
        //    Calculator c1 = new Calculator(4);
        //    int actual = c1.FindFactorial();
        //    Assert.Equal(24, actual);
        //}

        [Theory]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        public void TestFindFactorials(int value, int expected)
        {
            Calculator c1 = new Calculator(value);
            int actual = c1.FindFactorial();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFindFactors1()
        {
            Calculator c1 = new Calculator(12);
            List<int> actual = c1.FindFactors();
            List<int> expected = new List<int>() { 1, 2, 3, 4, 6, 12};
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, new int[] {1, 2, 3, 4, 6, 12})]
        [InlineData(10, new int[] {1, 2, 5, 10})]
        public void TestFindFactors(int value, int[] expected)
        {
            Calculator c1 = new Calculator(value);
            List<int> actual = c1.FindFactors();
            List<int> realexpected = new List<int>(expected);
            Assert.Equal(expected, actual);
        }
    }
} 