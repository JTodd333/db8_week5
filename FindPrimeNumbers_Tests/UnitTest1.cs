using FindPrimeNumbers;

namespace FindPrimeNumbers_Tests
{
    public class UnitTest1
    {
        //Indexes next to input
        [Theory]
        [InlineData(0, 2)]
        [InlineData(1, 3)]
        [InlineData(10, 31)]
        [InlineData(14, 47)]
        [InlineData(24, 97)]
        public void TestClass(int value, int expected)
        {

            int actual = Prime.GetPrime(value);
            Assert.Equal(expected, actual);
        }
    }
}