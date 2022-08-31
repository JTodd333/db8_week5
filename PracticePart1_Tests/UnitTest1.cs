using PacticePart1;
namespace PracticePart1_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-1, -1)] // Group these together. Neg First
        [InlineData(-2, -1)]
        [InlineData(0, 0)]
        [InlineData(1, 1)] // Group these together. Positives
        [InlineData(2, 1)]
        [InlineData(26523, 1)] //If code was written only for -2 through 2
        [InlineData(-45123, -1)] // We might not catch without these
        public void Test1(int value, int expected)
        {
            int actual = Coupon.GetSign(value);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5.0, 0)]
        [InlineData(9.99, 0)]
        [InlineData(10.00, 2.0)]
        [InlineData(19.99, 2.0)]
        [InlineData(20.00, 3.0)]
        [InlineData(20.01, 3.0)]
        [InlineData(100.0, 3.0)]
        public void TestCalcCoupon(decimal value, decimal expected)
        {
            decimal actual = Coupon.CalculateCoupon(value);
            Assert.Equal(expected, actual);
        }
    }
}